using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.GitLab.Commands.PushToRepository
{
    public class PushToGitLabRepositoryCommand : IPushToGitLabRepositoryCommand
    {
        private readonly IGitService _gitService;

        public PushToGitLabRepositoryCommand(IGitService gitService)
        {
            _gitService = gitService;
        }

        public async Task<PushToRepositoryResponse> ExecuteAsync(PushToRepositoryRequest request)
        {
            await _gitService.PushToRepositoryAsync(request.RepositoryUrl, (s) => { });

            return new PushToRepositoryResponse();
        }
    }
}