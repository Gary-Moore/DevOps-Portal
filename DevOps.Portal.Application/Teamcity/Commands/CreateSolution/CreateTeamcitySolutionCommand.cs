using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateBuild;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject.Factory;
using DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot;
using DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory;
using DevOps.Portal.Application.Teamcity.Commands.UpdateBuildParameter;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.Teamcity.Queries.GetProjects;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public class CreateTeamcitySolutionCommand : ICreateTeamcitySolutionCommand
    {
        private readonly ICreateTeamcityProjectFactory _modelFactory;
        private readonly ITeamcityVcsRootModelFactory _vcsModelFactory;
        private readonly ICreateProjectCommand _createProjectCommand;
        private readonly ICreateBuildCommand _createBuildCommand;
        private readonly ICreateVcsRootCommand _createVcsRootCommand;
        private readonly IUpdateBuildParameterCommand _updateBuildParameterCommand;
        private readonly IGetProjectByIdQuery _getProjectQuery;

        public CreateTeamcitySolutionCommand(ICreateTeamcityProjectFactory modelFactory,
            ITeamcityVcsRootModelFactory vcsModelFactory,
            ICreateProjectCommand createProjectCommand,
            ICreateBuildCommand createBuildCommand,
            ICreateVcsRootCommand createVcsRootCommand, 
            IUpdateBuildParameterCommand updateBuildParameterCommand,
            IGetProjectByIdQuery getProjectQuery)
        {
            _modelFactory = modelFactory;
            _vcsModelFactory = vcsModelFactory;
            _createProjectCommand = createProjectCommand;
            _createBuildCommand = createBuildCommand;
            _createVcsRootCommand = createVcsRootCommand;
            _updateBuildParameterCommand = updateBuildParameterCommand;
            _getProjectQuery = getProjectQuery;
        }
        
        public async Task<CreateTeamCitySolutionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            notifyAction(model, "Teamcity build started");
            Project parentProject;

            // Create Main Project
            if (string.IsNullOrWhiteSpace(model.TeamCityParentProjectId))
            {
                var mainProjectModel = _modelFactory.Create(model.TeamCityNewParentProjectName);
                parentProject = await _createProjectCommand.ExecuteAsync(mainProjectModel);
            }
            else
            {
                parentProject = await _getProjectQuery.Execute(model.TeamCityParentProjectId);
            }
            
            // Create Sub Project
            var subProjectModel = _modelFactory.Create(model.TeamCitySubprojectName, parentProject.Id);

            var subProject = await _createProjectCommand.ExecuteAsync(subProjectModel);

            // Create Build
            var build = await _createBuildCommand.ExecuteAsync(subProject.Id);
            var param = await _updateBuildParameterCommand.Execute(build, "SolutionName", model.VisualStudioSolutionName);
            
            // Create VCS Root and attach to build
            var vcsModel =  _vcsModelFactory.Create(model.TeamCitySubprojectName + " master", subProject.Id, model.SourceControlUrl);
            var vcs = await _createVcsRootCommand.Execute(vcsModel, build.Id);
            notifyAction(model, "Teamcity build complete");

           return new CreateTeamCitySolutionResponse()
            {
                ParentProject = parentProject,
                SubProject = subProject,
                TypVcsRoot = vcs
            };
        }
    }
}
