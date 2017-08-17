using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public interface ITeamcityService
    {
        Task<VcsRoot> AttachVcsRoot(string attachJson, string buildId);
        Task<IEnumerable<Project>> GetProjects();
        Task<VcsRoot> CreateVcsRoot(string urlName);
        Task<Project> CreateProjectAsync(string createProjectJson);
        Task<Build> CreateBuildAsync(string createBuildJson, string projectId);
        Task<Build> UpdateBuildTemplateAsync(string buildId, string templateId);
        Task<IEnumerable<BuildType>> GetBuildTemplates();
        void ActivateBuild(string projectId);
    }
}