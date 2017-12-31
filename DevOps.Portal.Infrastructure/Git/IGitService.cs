using System;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Scripts;

namespace DevOps.Portal.Infrastructure.Git
{
    public interface IGitService
    {
        Task DownloadProjectAsync(string projectUrl, string filePath);
        Task<ScriptExecutionResult> CloneProject(string projectUrl, Action<string> callback);
    }
}