using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public interface ITeamcityService
    {
        Task<IEnumerable<Project>> GetProjects();
        Task<VcsRoot> CreateVcsRoot(string urlName);
        Task<Project> CreateProjectAsync(string createProjectJson);
        Task<Build> CreateBuildAsync(string createBuildJson, string projectId);
        Task<Build> UpdateBuildTemplateAsync(string buildId, string templateId);
        void ActivateBuild(string projectId);
    }
}