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
        private readonly string _gitLabBaseUrl;
        private readonly CustomHeader _customHeader;

        public GitLabService(IHttpClientWrapper httpClientWrapper, IConfiguration configuration)
        {
            _httpClientWrapper = httpClientWrapper;
            _gitLabBaseUrl = configuration.GitLabUrl;
            _customHeader = new CustomHeader("Private-Token", configuration.GitLabPrivateToken);
        }

        public async Task<Project> Create(string createProjectJson)
        {
            var result = await _httpClientWrapper.PostDataAsync(ProjectsUrl, createProjectJson, MediaContentTypes.Json,
               null, JsonConvert.DeserializeObject<Project>, _customHeader);

            return result.ResponseData;
        }

        public async Task<IEnumerable<Project>> Get()
        {
            var result = await _httpClientWrapper.GetDataAsync(ProjectsUrl, null, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<IEnumerable<Project>>, _customHeader);

            return result.ResponseData;
        }

        public async Task<Project> GetById(string id)
        {
            var result = await _httpClientWrapper.GetDataAsync(ProjectUrl(id), null, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<Project>, _customHeader);

            return result.ResponseData;
        }

        public async Task<Project> Update(string updateProjectJson)
        {   
            var result = await _httpClientWrapper.PutDataAsync(ProjectsUrl, updateProjectJson, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<Project>);

            return result.ResponseData;
        }

        public async Task<Group> CreateGroup(string createGroupJson)
        {
            var response = await _httpClientWrapper.PostDataAsync(GroupsUrl, createGroupJson, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<Group>, _customHeader);
            
            if (response.Success)
            {
                return response.ResponseData;
            }

            throw new GitLabOperationException(response.Errors, "Error creating a GitLab group");
        }

        public async Task<Group> UpdateGroup(string updateGroupJson)
        {
            var result = await _httpClientWrapper.PostDataAsync(GroupsUrl, updateGroupJson, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<Group>, _customHeader);

            return result.ResponseData;
        }

        public async Task<bool> DeleteGroup(string id)
        {
            var response = await _httpClientWrapper.DeleteDataAsync(DeleteGroupUrl(id), null, MediaContentTypes.Json,
                null, JsonConvert.DeserializeObject<Group>, _customHeader);

            if (response.Success)
            {
                return response.Success;
            }

            throw new GitLabOperationException(response.Errors, "Error deleting a GitLab group");
        }

        private Uri GitLabApiBaseUrl => new Uri($"{_gitLabBaseUrl}/api/v4");
        private Uri ProjectsUrl => new Uri($"{GitLabApiBaseUrl}/projects");
        private Uri ProjectUrl(string id) => new Uri($"{ProjectsUrl}/id:{id}");
        private Uri GroupsUrl => new Uri($"{GitLabApiBaseUrl}/groups");
        private Uri DeleteGroupUrl(string id) => new Uri($"{GroupsUrl}/{id}");
    }
}
