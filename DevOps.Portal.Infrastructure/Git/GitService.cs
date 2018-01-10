using System;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Scripts;

namespace DevOps.Portal.Infrastructure.Git
{
    public class GitService : IGitService
    {
        private readonly IConfiguration _configuration;

        public GitService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task<ScriptExecutionResult> CloneProjectAsync(string projectUrl, Action<string> callback)
        {
            var cloneProjectScript = new PowershellScript("Clone-TemplateProject.ps1", callback);
            cloneProjectScript.AddArgument("repoUrl", projectUrl);
            cloneProjectScript.AddArgument("checkoutPath", _configuration.DownloadDirectory);

            var result = await Task.Run(() => cloneProjectScript.ExecuteAync());
            return result;
        }

        public async Task<ScriptExecutionResult> PushToRepositoryAsync(string repositoryUrl, Action<object> callback)
        {
            var cloneProjectScript = new PowershellScript("Create-GitRepository.ps1", callback);
            cloneProjectScript.AddArgument("repoUrl", repositoryUrl);
            cloneProjectScript.AddArgument("workingDirPath", _configuration.WorkingDirectory);

            var result = await Task.Run(() => cloneProjectScript.ExecuteAync());
            return result;
        }
    }
}
