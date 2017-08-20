using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Client;
using DevOps.Portal.Business.ConfigurationSettings;

namespace DevOps.Portal.Business.Services
{
    public class OctopusService
    {
        OctopusConfiguration _config;
        public OctopusService()
        {
           _config = new OctopusConfiguration();
        }

        public string CreateProject()
        {
            var endpoint = new OctopusServerEndpoint(_config.OctopusEndpointUrl, _config.ApiKey);
            var repository = new OctopusRepository(endpoint);

            repository.Projects.Create()
        }
    }
}
