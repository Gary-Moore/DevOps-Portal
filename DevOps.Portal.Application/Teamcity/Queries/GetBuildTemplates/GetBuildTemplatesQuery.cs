using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetBuildTemplates
{
    public class GetBuildTemplatesQuery : IGetBuildTemplatesQuery
    {
        private readonly ITeamcityService _teamcityService;

        public GetBuildTemplatesQuery(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }
        
        public async Task<IEnumerable<BuildType>> Execute()
        {
            return await _teamcityService.GetBuildTemplates();
        }
    }
}
