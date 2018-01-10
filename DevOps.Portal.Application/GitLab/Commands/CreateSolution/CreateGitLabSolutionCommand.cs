using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.GitLab.Commands.CreateGroup;
using DevOps.Portal.Application.GitLab.Commands.CreateGroup.Factory;
using DevOps.Portal.Application.GitLab.Commands.CreateProject;
using DevOps.Portal.Application.GitLab.Commands.CreateProject.Factory;
using DevOps.Portal.Application.GitLab.Commands.PushToRepository;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateSolution
{
    public class CreateGitLabSolutionCommand : ICreateGitLabSolutionCommand
    {
        private readonly ICreateGitLabGroupCommand _createGitLabGroupCommand;
        private readonly ICreateGitLabProjectCommand _createGitLabProjectCommand;
        private readonly IPushToGitLabRepositoryCommand _pushToGitLabRepositoryCommand;
        private readonly IGitLabProjectFactory _gitLabProjectFactory;
        private readonly IGitLabGroupFactory _gitLabGroupFactory;

        public CreateGitLabSolutionCommand(ICreateGitLabGroupCommand createGitLabGroupCommand, 
            ICreateGitLabProjectCommand createGitLabProjectCommand,
            IPushToGitLabRepositoryCommand pushToGitLabRepositoryCommand,
            IGitLabProjectFactory gitLabProjectFactory,
            IGitLabGroupFactory gitLabGroupFactory)
        {
            _createGitLabGroupCommand = createGitLabGroupCommand;
            _createGitLabProjectCommand = createGitLabProjectCommand;
            _pushToGitLabRepositoryCommand = pushToGitLabRepositoryCommand;
            _gitLabProjectFactory = gitLabProjectFactory;
            _gitLabGroupFactory = gitLabGroupFactory;
        }

        public async Task<CreateGitLabSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction)
        {
            var group = _gitLabGroupFactory.Create(model.GitLabProjectName, model.GitLabGroupPath);
            var newGroup = await _createGitLabGroupCommand.ExecuteAsync(group);

            var project = _gitLabProjectFactory.Create(model.GitLabProjectName, model.GitLabProjectDescription, newGroup.Id);
            project = await _createGitLabProjectCommand.ExecuteAsync(project);

            var pushRequest = new PushToRepositoryRequest() {RepositoryUrl = project.HttpUrl};
            var repoResponse = await _pushToGitLabRepositoryCommand.ExecuteAsync(pushRequest);

            return new CreateGitLabSolutionResponse()
            {
                Group = newGroup,
                Project = project,
                PushToRepositorySuccessful = repoResponse.Successful
            };
        }
    }
}
