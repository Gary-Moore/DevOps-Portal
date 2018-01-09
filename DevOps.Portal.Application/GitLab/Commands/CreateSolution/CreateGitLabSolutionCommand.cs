using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.GitLab.Commands.CreateGroup;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateSolution
{
    public class CreateGitLabSolutionCommand : ICreateGitLabSolutionCommand
    {
        private readonly ICreateGitLabGroupCommand _createGitLabGroupCommand;

        public CreateGitLabSolutionCommand(ICreateGitLabGroupCommand createGitLabGroupCommand)
        {
            _createGitLabGroupCommand = createGitLabGroupCommand;
        }

        public async Task<CreateGitLabSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction)
        {
            var group = new Group();
            var newGroup = await _createGitLabGroupCommand.ExecuteAsync(group);
            return new CreateGitLabSolutionResponse(){ Group = newGroup };
        }
    }
}
