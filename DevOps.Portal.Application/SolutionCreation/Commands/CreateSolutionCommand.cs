using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;

namespace DevOps.Portal.Application.SolutionCreation.Commands
{
    public class CreateSolutionCommand : ICreateSolutionCommand
    {
        private readonly ICreateTeamcitySolutionCommand _createTeamcitySolutionCommand;

        public CreateSolutionCommand(ICreateTeamcitySolutionCommand createTeamcitySolutionCommand)
        {
            _createTeamcitySolutionCommand = createTeamcitySolutionCommand;
        }

        public Task<CreateSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction)
        {
            throw new NotImplementedException();
        }
    }
}
