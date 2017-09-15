namespace DevOps.Portal.Infrastructure.Configuration
{
    public interface IConfiguration
    {
        string TeamcityHost { get; }
        string TeamcityPassword { get; }
        string TeamcityUsername { get; }
        string WorkingDirectory { get; }
    }
}