using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace DevOps.Portal.Core.Infrastructure.AzureResources
{
    public class AzureService : IAzureService
    {
        private readonly IAzureConfiguration _azureConfiguration;

        public AzureService(IAzureConfiguration azureConfiguration)
        {
            _azureConfiguration = azureConfiguration;
        }

        public async Task<IEnumerable<IVirtualMachine>> GetList()
        {
            var credentials = new AzureCredentialsFactory()
                .FromServicePrincipal(_azureConfiguration.ClientId, 
                    _azureConfiguration.ClientSecret, 
                    _azureConfiguration.TenantId,
                    AzureEnvironment.AzureGlobalCloud);

            var azure = Azure.Authenticate(credentials).WithSubscription(_azureConfiguration.Subscription);

            var vms = await azure.VirtualMachines.ListAsync();
            return vms.ToList();
        }
    }
}
