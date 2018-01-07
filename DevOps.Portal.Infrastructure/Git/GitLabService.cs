using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Network;
using Newtonsoft.Json;

namespace DevOps.Portal.Infrastructure.Git
{
    public class GitLabService : IGitLabService
    {
        private readonly IHttpClientWrapper _httpClientWrapper;
        private readonly IConfiguration _configuration;
        private readonly string _gitLabBaseUrl;
        private readonly NetworkCredential _networkCredential;

        public GitLabService(IHttpClientWrapper httpClientWrapper, IConfiguration configuration)
        {
            _httpClientWrapper = httpClientWrapper;
            _configuration = configuration;
            _gitLabBaseUrl = configuration.GitLabUrl;
        }

        public async Task<Project> Create(string createProjectJson)
        {
            var result = await _httpClientWrapper.PostDataAsync(ProjectsUrl, createProjectJson, MediaContentTypes.Json,
                _networkCredential, JsonConvert.DeserializeObject<Project>);

            return result.ResponseData;
        }

        public async Task<IEnumerable<Project>> Get()
        {
            var result = await _httpClientWrapper.GetDataAsync(ProjectsUrl, null, MediaContentTypes.Json,
                _networkCredential,
                JsonConvert.DeserializeObject<IEnumerable<Project>>);

            return result.ResponseData;
        }

        public async Task<Project> GetById(string id)
        {
            var result = await _httpClientWrapper.GetDataAsync(ProjectUrl(id), null, MediaContentTypes.Json,
                _networkCredential,
                JsonConvert.DeserializeObject<Project>);

            return result.ResponseData;
        }

        public async Task<Project> Update(string updateProjectJson)
        {   
            var result = await _httpClientWrapper.PutDataAsync(ProjectsUrl, updateProjectJson, MediaContentTypes.Json,
                _networkCredential, JsonConvert.DeserializeObject<Project>);

            return result.ResponseData;
        }

        public async Task<Group> CreateGroup(string createGroupJson)
        {
            var result = await _httpClientWrapper.PostDataAsync(GroupsUrl, createGroupJson, MediaContentTypes.Json,
                _networkCredential, JsonConvert.DeserializeObject<Group>);

            return result.ResponseData;
        }

        public async Task<Group> UpdateGroup(string updateGroupJson)
        {
            var result = await _httpClientWrapper.PostDataAsync(GroupsUrl, updateGroupJson, MediaContentTypes.Json,
                _networkCredential, JsonConvert.DeserializeObject<Group>);

            return result.ResponseData;
        }

        public async Task DeleteGroup(string deleteGroupJson)
        {
            var result = await _httpClientWrapper.DeleteDataAsync(GroupsUrl, deleteGroupJson, MediaContentTypes.Json,
                _networkCredential, JsonConvert.DeserializeObject<Group>);
            
        }

        private Uri GitLabApiBaseUrl => new Uri($"{_gitLabBaseUrl}/api/v4");
        private Uri ProjectsUrl => new Uri($"{GitLabApiBaseUrl}/projects");
        private Uri ProjectUrl(string id) => new Uri($"{ProjectsUrl}/id:{id}");
        private Uri GroupsUrl => new Uri($"{GitLabApiBaseUrl}/groups");
    }
}
