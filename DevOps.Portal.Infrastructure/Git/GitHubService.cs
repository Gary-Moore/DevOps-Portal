using System;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Network;

namespace DevOps.Portal.Infrastructure.Git
{
    public class GitHubService : IGitHubService
    {
        private readonly IHttpClientWrapper _client;

        public GitHubService(IHttpClientWrapper client)
        {
            _client = client;
        }

        public async Task DownloadProjectAsync(string projectUrl, string filePath)
        {
            await _client.DownloadZip(DownloadProjectUrl(projectUrl), filePath);
        }

        private static Uri DownloadProjectUrl(string templateUrl) => new Uri(templateUrl);
    }
}
