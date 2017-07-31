using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public interface ITeamcityService
    {
        Task<IEnumerable<Project>> GetProjects();

        Task<string> CreateProject(string name);

        void ActivateBuild(string projectId);
    }
}