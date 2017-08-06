using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateBuild;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject.Factory;
using DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot;
using DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public class CreateTeamcitySolutionCommand : ICreateTeamcitySolutionCommand
    {
        private readonly ICreateTeamcityProjectFactory _modelFactory;
        private readonly ITeamcityVcsRootModelFactory _vcsModelFactory;
        private readonly ICreateProjectCommand _createProjectCommand;
        private readonly ICreateBuildCommand _createBuildCommand;
        private readonly ICreateVcsRootCommand _createVcsRootCommand;

        public CreateTeamcitySolutionCommand(ICreateTeamcityProjectFactory modelFactory,
            ITeamcityVcsRootModelFactory vcsModelFactory,
            ICreateProjectCommand createProjectCommand,
            ICreateBuildCommand createBuildCommand,
            ICreateVcsRootCommand createVcsRootCommand)
        {
            _modelFactory = modelFactory;
            _vcsModelFactory = vcsModelFactory;
            _createProjectCommand = createProjectCommand;
            _createBuildCommand = createBuildCommand;
            _createVcsRootCommand = createVcsRootCommand;
        }

        public async Task Execute(string mainProjectName, string subProjectName, string sourceControlUrl)
        {
           // Create Main Project
            var mainProjectModel = _modelFactory.Create(mainProjectName);
            var parentProject = await _createProjectCommand.ExecuteAsync(mainProjectModel);

            // Create Sub Project
            var subProjectModel = _modelFactory.Create(subProjectName, parentProject.Id);
            var subProject = await _createProjectCommand.ExecuteAsync(subProjectModel);

            // Create Build
            var build = await _createBuildCommand.ExecuteAsync(subProject.Id);
            
            // Create VCS Root and attach to build
            var vcsModel =  _vcsModelFactory.Create(subProjectName + " master", subProject.Id, sourceControlUrl);
            var vcs = await _createVcsRootCommand.Execute(vcsModel, build.Id);
        }
    }
}
