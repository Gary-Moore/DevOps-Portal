using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Configuration;
using Octopus.Client;
using Octopus.Client.Model;

namespace DevOps.Portal.Infrastructure.Octopus
{
    public class OctopusService : IOctopusService
    {
        private readonly OctopusServerEndpoint _endpoint;

        public OctopusService(IConfiguration configuration)
        {
            _endpoint = new OctopusServerEndpoint(configuration.OctopusServerUrl, configuration.OctopusApiKey);
        }

        public async Task<ProjectGroupResource> CreateGroupAsync(ProjectGroupResource group)
        {
            using (var client = await OctopusAsyncClient.Create(_endpoint))
            {
                var repo = client.CreateRepository();

                return await repo.ProjectGroups.Create(group);
            }
        }

        public async Task<ProjectResource> CreateProjectAsync(ProjectResource project)
        {
            using (var client = await OctopusAsyncClient.Create(_endpoint))
            {
                var repo = client.CreateRepository();

                return await repo.Projects.Create(project);
            }
        }
    }
}
