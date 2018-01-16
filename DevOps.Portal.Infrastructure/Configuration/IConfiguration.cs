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
        string OctopusApiKey { get; }
        string OctopusServerUrl { get; }
        string AzureClientId { get; }
        string AzureClientSecret { get; }
        string AzureTenantId { get; }
    }
}