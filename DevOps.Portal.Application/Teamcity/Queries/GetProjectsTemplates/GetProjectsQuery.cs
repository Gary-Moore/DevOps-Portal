using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetProjectsTemplates
{
    public class GetProjectsQuery : IGetProjectsQuery
    {
        private readonly ITeamcityService _teamcityService;

        public GetProjectsQuery(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public async Task<IEnumerable<Project>> Execute(string searchTerm)
        {
            var projects = await _teamcityService.GetProjects();

            projects = projects.Where(proj => proj.Id != "_Root");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                projects = projects.Where(proj => proj.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            return projects;
        }
    }
}
