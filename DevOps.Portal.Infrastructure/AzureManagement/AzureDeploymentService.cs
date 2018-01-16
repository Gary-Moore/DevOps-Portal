using System.IO;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Configuration;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevOps.Portal.Infrastructure.AzureManagement
{
    public class AzureDeploymentService : IAzureDeploymentService
    {
        private readonly IConfiguration _configuration;

        public AzureDeploymentService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task DeployTemplate()
        {
            var azureCredentials = SdkContext.AzureCredentialsFactory
                .FromServicePrincipal(_configuration.AzureClientId, _configuration.AzureClientSecret,
                    _configuration.AzureTenantId, AzureEnvironment.AzureGlobalCloud);

            var azure = Azure.Configure()
                .Authenticate(azureCredentials)
                .WithSubscription("6a5f5e87-6c32-4edb-a253-1cff59db617b");

            JObject templateFileContents = GetJsonFileContents(@"D:\Development\Projects\Microsoft\DevOps\DevOps-Portal\DevOps.Portal.WebApp.AzureResourceGroup\WebSite.json");
            JObject parameterFileContents = GetJsonFileContents(@"D:\Development\Projects\Microsoft\DevOps\DevOps-Portal\DevOps.Portal.WebApp.AzureResourceGroup\WebSite.parameters.json");

            await azure.Deployments
                .Define("newdeployment")
                .WithExistingResourceGroup("rg-devops-portal")
                .WithTemplate(templateFileContents)
                .WithParameters(parameterFileContents["parameters"].ToObject<JObject>())
                .WithMode(DeploymentMode.Incremental)
                .CreateAsync();
        }

        public JObject GetJsonFileContents(string filePath)
        {
            var templateFileContent = new JObject();
            using (var file = File.OpenText(filePath))
            {
                using (var reader = new JsonTextReader(file))
                {
                    templateFileContent = (JObject) JToken.ReadFrom(reader);
                    return templateFileContent;
                }
            }
        }
    }
}
