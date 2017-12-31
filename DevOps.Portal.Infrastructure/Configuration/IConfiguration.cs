namespace DevOps.Portal.Infrastructure.Configuration
{
    public interface IConfiguration
    {
        string TeamcityHost { get; }
        string TeamcityPassword { get; }
        string TeamcityUsername { get; }
        string WorkingDirectory { get; }
        string TableStorageUrl { get; }
        string StorageAccountKey { get; }
        string StorageAccountName { get; }
        string GitLocation { get; }
    }
}