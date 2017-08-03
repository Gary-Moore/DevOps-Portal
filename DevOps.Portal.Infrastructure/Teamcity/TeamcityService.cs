using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Network;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            var projects = await _client.SendDataAsync(TeamCityProjectsUrl, String.Empty, _credentials,
                ParseProjectJson);

            return projects;
        }
        
        public void ActivateBuild(string projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> CreateProjectAsync(string createProjectJson)
        {
            var result = await _client.PostDataAsync(TeamCityProjectsUrl, createProjectJson,
                MediaContentTypes.Json, _credentials, JsonConvert.DeserializeObject<Project>);

            return result.ResponseData;
        }

        private Uri TeamCityProjectsUrl => new Uri($"{_teamcityUrl}/httpAuth/app/rest/projects");

        private static IEnumerable<Project> ParseProjectJson(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["project"].Children().Select(proj => proj.ToObject<Project>()).ToList();
        }
    }
}
