using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
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

        public async Task<VcsRoot> AttachVcsRoot(string attachJson, string buildId)
        {
            var response = await _client.PostDataAsync(TeamCityBuildRootEntriesUrl(buildId), attachJson, MediaContentTypes.Json,
                _credentials, JsonConvert.DeserializeObject<VcsRoot>);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error attaching a TeamCity VCS root");
        }

        public async Task<Project> GetProject(string id)
        {
            var response = await _client.GetDataAsync(TeamCityProjectUrl(id), null, MediaContentTypes.Json,
                _credentials, JsonConvert.DeserializeObject<Project>);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error retrieving teamcity project");
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            var response = await _client.GetDataAsync(TeamCityProjectsUrl, null, MediaContentTypes.Json,
                _credentials, ParseProjectJson);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error retrieving teamcity projects");
        }

        public async Task<VcsRoot> CreateVcsRoot(string createvcsRootJson)
        {
            var response = await _client.PostDataAsync(TeamCityVcsRootUrl, createvcsRootJson, 
                MediaContentTypes.Json, _credentials, JsonConvert.DeserializeObject<VcsRoot>);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error creating a TeamCity VCS root"); 
        }

        public async Task<IEnumerable<BuildType>> GetBuildTemplates()
        {
            var response = await _client.GetDataAsync(TeamCityBuildTemplatesUrl, null, MediaContentTypes.Json,
                _credentials, ParseBuildTypeJson);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error retrieving build templates");
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

        public async Task<Build> CreateBuildAsync(string buildName, string projectId)
        {
            var response = await _client.PostDataAsync(TeamCityProjectBuildsUrl(projectId), buildName,
                MediaTypeNames.Text.Plain, _credentials, JsonConvert.DeserializeObject<Build>);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error creating a build");
        }

        public async Task<Build> UpdateBuildTemplateAsync(string buildId, string templateId)
        {
            var response = await _client.PutDataAsync(TeamCityBuildTemplateUrl(buildId), templateId,
                MediaTypeNames.Text.Plain, _credentials, JsonConvert.DeserializeObject<Build>);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error updating build with template"); 
        }

        public async Task<string> UpdateBuildParameter(string buildId, string parameterName, string parameterValue)
        {
            var response = await _client.PutDataAsync(TeamCityBuildParametersUrl(buildId, parameterName),
                parameterValue,
                MediaTypeNames.Text.Plain, _credentials, (res) => res, MediaTypeNames.Text.Plain);

            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new TeamCityOperationException(response.Errors, "Error updating build parameter");
        }

        private Uri TeamCityApiBaseUrl => new Uri($"{_teamcityUrl}/httpAuth/app/rest");
        private Uri TeamCityProjectsUrl => new Uri($"{_teamcityUrl}/httpAuth/app/rest/projects");
        private Uri TeamCityProjectUrl(string id) => new Uri($"{TeamCityProjectsUrl}/id:{id}");
        private Uri TeamCityProjectBuildsUrl(string projectId) => new Uri($"{_teamcityUrl}/httpAuth/app/rest/projects/id:{projectId}/buildTypes");
        private Uri TeamCityBuildTemplateUrl(string buildId) => new Uri($"{_teamcityUrl}/httpAuth/app/rest/buildTypes/id:{buildId}/template");
        private Uri TeamCityVcsRootUrl => new Uri($"{_teamcityUrl}/httpAuth/app/rest/vcs-roots/");
        private Uri TeamCityBuildRootEntriesUrl(string buildId) => new Uri($"{_teamcityUrl}/httpAuth/app/rest/buildTypes/id:{buildId}/vcs-root-entries"); 
        private Uri TeamCityBuildTemplatesUrl => new Uri($"{_teamcityUrl}/httpAuth/app/rest/buildTypes?locator=templateFlag:true");
        private Uri TeamCityBuildParametersUrl(string buildId, string parameterId) => new Uri($"{TeamCityApiBaseUrl}/buildTypes/id:{buildId}/parameters/{parameterId}");

        private static IEnumerable<Project> ParseProjectJson(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["project"].Children().Select(proj => proj.ToObject<Project>()).ToList();
        }

        private static IEnumerable<BuildType> ParseBuildTypeJson(string json)
        {
            var jsonObject = JObject.Parse(json);

            return jsonObject["buildType"].Children().Select(proj => proj.ToObject<BuildType>()).ToList();
        }
    }
}
