using System;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Network;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Scripts;

namespace DevOps.Portal.Infrastructure.Git
{
    public class GitService : IGitService
    {
        private readonly IHttpClientWrapper _client;
        private readonly IConfiguration _configuration;

        public GitService(IHttpClientWrapper client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task DownloadProjectAsync(string projectUrl, string filePath)
        {
            await _client.DownloadZip(DownloadProjectUrl(projectUrl), filePath);
        }

        public async Task<ScriptExecutionResult> CloneProject(string projectUrl, Action<string> callback)
        {
            var cloneProjectScript = new PowershellScript("Clone-TemplateProject.ps1", callback);
            cloneProjectScript.AddArgument("repoUrl", projectUrl);
            cloneProjectScript.AddArgument("checkoutPath", _configuration.WorkingDirectory);

            var result = await Task.Run(() => cloneProjectScript.ExecuteAync());
            return result;
        }

        private static Uri DownloadProjectUrl(string templateUrl) => new Uri(templateUrl);
    }
}
