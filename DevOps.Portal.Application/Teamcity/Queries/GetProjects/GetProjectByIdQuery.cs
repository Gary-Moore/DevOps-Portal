using System;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetProjects
{
    public class GetProjectByIdQuery : IGetProjectByIdQuery
    {
        private readonly ITeamcityService _teamcityService;

        public GetProjectByIdQuery(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public async Task<Project> Execute(string id)
        {
            return await _teamcityService.GetProject(id);
        }
    }
}
