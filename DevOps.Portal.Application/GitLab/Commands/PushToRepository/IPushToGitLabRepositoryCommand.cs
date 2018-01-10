using System.Threading.Tasks;

namespace DevOps.Portal.Application.GitLab.Commands.PushToRepository
{
    public interface IPushToGitLabRepositoryCommand
    {
        Task<PushToRepositoryResponse> ExecuteAsync(PushToRepositoryRequest request);
    }
}