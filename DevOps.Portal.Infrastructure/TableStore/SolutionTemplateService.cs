using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.VisualStudio;
using Microsoft.WindowsAzure.Storage.Table;
using DevOps.Portal.Infrastructure.Configuration;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Azure;
using System.Linq;

namespace DevOps.Portal.Infrastructure.TableStore
{
    public class SolutionTemplateService : ISolutionTemplateService
    {
        private CloudTableClient tableClient;
        private CloudStorageAccount storageAccount;
        private readonly IConfiguration _configuration;

        public SolutionTemplateService(IConfiguration configuration)
        {
            _configuration = configuration;
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
        }

        public IEnumerable<SolutionTemplate> Get()
        {
            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("devopsportaltemplates");
            TableQuery<SolutionTemplate> query = new TableQuery<SolutionTemplate>();

            return table.ExecuteQuery(query).ToList();
        }

        private Uri TableStorageUri => new Uri(_configuration.TableStorageUrl);
        private StorageCredentials StorageCredentials => new StorageCredentials(_configuration.StorageAccountName, _configuration.StorageAccountKey); 
    }
}
