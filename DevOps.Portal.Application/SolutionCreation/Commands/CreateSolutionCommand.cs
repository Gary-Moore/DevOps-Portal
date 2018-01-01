using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;
using DevOps.Portal.Application.VisualStudio.Commands.CreateSolution;

namespace DevOps.Portal.Application.SolutionCreation.Commands
{
    public class CreateSolutionCommand : ICreateSolutionCommand
    {
        private readonly ICreateVisualStudioSolutionCommand _createVisualStudioSolutionCommand;
        private readonly ICreateTeamcitySolutionCommand _createTeamcitySolutionCommand;

        public CreateSolutionCommand(ICreateVisualStudioSolutionCommand createVisualStudioSolutionCommand,
            ICreateTeamcitySolutionCommand createTeamcitySolutionCommand)
        {
            _createVisualStudioSolutionCommand = createVisualStudioSolutionCommand;
            _createTeamcitySolutionCommand = createTeamcitySolutionCommand;
        }

        public async Task<CreateSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction)
        {
            notifyAction(model, "Solution creation process started");

            var visualStudioResponse  = await _createVisualStudioSolutionCommand.ExecuteAsync(model, notifyAction);

            var teamCityResponse = await _createTeamcitySolutionCommand.ExecuteAsync(model, notifyAction);

            return new CreateSolutionResponse();
        }
    }
}
