using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.Octopus.Commands.CreateProject;
using DevOps.Portal.Application.SolutionCreation;
using Octopus.Client.Model;

namespace DevOps.Portal.Application.Octopus.Commands.CreateSolution
{
    public class CreateOctopusSolutionCommand : ICreateOctopusSolutionCommand
    {
        private readonly ICreateOctopusProjectCommand _createOctopusProjectCommand;

        public CreateOctopusSolutionCommand(ICreateOctopusProjectCommand createOctopusProjectCommand)
        {
            _createOctopusProjectCommand = createOctopusProjectCommand;
        }

        public async Task<CreateOctopusSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction)
        {
            // get group or create new
            var project = new ProjectResource()
            {
                Name = model.OctopusProjectName,
                ProjectGroupId = model.OctopusGroupId,
                LifecycleId = model.OctopusLifeCycleId
            };
            project = await _createOctopusProjectCommand.ExecuteAsync(project);

            return new CreateOctopusSolutionResponse()
            {
                Project = project
            };
        }
    }
}
