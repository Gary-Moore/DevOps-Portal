using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public interface ITeamcityService
    {
        void ActivateBuild(string projectId);
        Task<VcsRoot> AttachVcsRoot(string attachJson, string buildId);
        
        Task<VcsRoot> CreateVcsRoot(string urlName);
        Task<Project> CreateProjectAsync(string createProjectJson);
        Task<Build> CreateBuildAsync(string createBuildJson, string projectId);

        Task<Project> GetProject(string id);
        Task<IEnumerable<Project>> GetProjects();
        Task<IEnumerable<BuildType>> GetBuildTemplates();

        Task<Build> UpdateBuildTemplateAsync(string buildId, string templateId);
        Task<string> UpdateBuildParameter(string buildId, string name, string parameter);
    }
}