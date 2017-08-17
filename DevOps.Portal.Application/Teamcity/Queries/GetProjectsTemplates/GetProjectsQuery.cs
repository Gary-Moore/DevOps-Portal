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

        public async Task<IEnumerable<Project>> Execute()
        {
            return await _teamcityService.GetProjects();
        }
    }
}
