using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetProjects
{
    public class GetProjectsQuery : IGetProjectsQuery
    {
        private readonly ITeamcityService _teamcityService;
        private const string RootProjectId = "_Root";

        public GetProjectsQuery(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public async Task<IEnumerable<Project>> Execute(string searchTerm, ProjectSearchLevel searchLevel)
        {
            var projects = await _teamcityService.GetProjects();

            projects = projects.Where(proj => proj.Id != RootProjectId);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                projects = projects.Where(proj => proj.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            if (searchLevel == ProjectSearchLevel.Root)
            {
                projects = projects.Where(proj => proj.ParentProjectId == RootProjectId);
            }

            return projects;
        }
    }
}
