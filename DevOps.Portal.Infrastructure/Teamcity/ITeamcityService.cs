using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public interface ITeamcityService
    {
        Task<IEnumerable<Project>> GetProjects();

        Task<Project> CreateProjectAsync(string createProjectJson);

        void ActivateBuild(string projectId);
    }
}