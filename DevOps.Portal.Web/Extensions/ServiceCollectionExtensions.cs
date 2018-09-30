using DevOps.Portal.Core.Infrastructure.AzureResources;

namespace Microsoft.Extensions.DependencyInjection 
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IAzureService, AzureService>();

            return services;
        }
    }
}
