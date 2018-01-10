using System;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Scripts;

namespace DevOps.Portal.Infrastructure.Git
{
    public interface IGitService
    {
        Task<ScriptExecutionResult> CloneProjectAsync(string projectUrl, Action<string> callback);
        Task<ScriptExecutionResult> PushToRepositoryAsync(string repositoryUrl, Action<object> callback);
    }
}