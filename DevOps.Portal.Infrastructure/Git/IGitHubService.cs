using System;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.Git
{
    public interface IGitHubService
    {
        Task DownloadProjectAsync(string projectUrl, string filePath);
    }
}