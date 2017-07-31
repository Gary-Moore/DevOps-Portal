using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Network;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public class TeamcityService : ITeamcityService
    {
        private readonly IHttpClientWrapper _client;
        private readonly string _teamcityUrl;
        private readonly NetworkCredential _credentials;

        public TeamcityService(IHttpClientWrapper client, IConfiguration configuration)
        {
            _client = client;
            _teamcityUrl = configuration.TeamcityHost;
            _credentials = new NetworkCredential(configuration.TeamcityUsername, configuration.TeamcityPassword);
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            var projects = await _client.GetDataAsync<IEnumerable<Project>>(TeamCityProjectsUrl, _credentials);

            return projects;
        }

        public void ActivateBuild(string projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> CreateProject(string name)
        {
            var result = await _client.PostDataAsync(TeamCityProjectsUrl, name, _credentials);

            return result;
        }

        private string TeamCityProjectsUrl => $"{_teamcityUrl}/httpAuth/app/rest/projects";
    }
}
