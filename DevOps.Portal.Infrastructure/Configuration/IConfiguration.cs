namespace DevOps.Portal.Infrastructure.Configuration
{
    public interface IConfiguration
    {
        string TeamcityHost { get; }
        string TeamcityPassword { get; }
        string TeamcityUsername { get; }
        string WorkingDirectory { get; }
        string DownloadDirectory { get; }
        string StorageUriEndpoint { get; }
        string StorageAccountKey { get; }
        string GitLabUrl { get; }
        string GitLabPrivateToken { get; }
    }
}