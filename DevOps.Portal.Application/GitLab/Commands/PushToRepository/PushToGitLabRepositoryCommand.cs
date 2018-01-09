using System.Threading.Tasks;

namespace DevOps.Portal.Application.GitLab.Commands.PushToRepository
{
    public class PushToGitLabRepositoryCommand : IPushToGitLabRepositoryCommand
    {
        public Task<PushToRepositoryResponse> ExecuteAsync(PushToRepositoryRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}