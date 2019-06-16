namespace DevOps.Portal.Core.Infrastructure.AzureResources
{
    public interface IAzureConfiguration
    {
        string ClientId { get; set; }

        string ClientSecret { get; }

        string TenantId { get; }

        string Subscription { get; }
    }
}