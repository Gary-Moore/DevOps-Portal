﻿using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject.Factory;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public class CreateTeamcitySolutionCommand : ICreateTeamcitySolutionCommand
    {
        private readonly ICreateTeamcityProjectFactory _modelFactory;
        private readonly ICreateProjectCommand _createProjectCommand;

        public CreateTeamcitySolutionCommand(ICreateTeamcityProjectFactory modelFactory,
            ICreateProjectCommand createProjectCommand)
        {
            _modelFactory = modelFactory;
            _createProjectCommand = createProjectCommand;
        }

        public async Task Execute(string mainProjectName, string subProjectName)
        {
           // Create Main Project
                var mainProjectModel = _modelFactory.Create(mainProjectName);
                var parentProject = await _createProjectCommand.ExecuteAsync(mainProjectModel);

                // Create Sub Project
                var subProjectModel = _modelFactory.Create(subProjectName, parentProject.Id);
                var subProject = await _createProjectCommand.ExecuteAsync(subProjectModel);

                // Create Build

                // Associate with template

                // Create VCS Root
        }
    }
}
