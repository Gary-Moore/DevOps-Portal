using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.UpdateBuildParameter
{
    public class UpdateBuildParameterCommand : IUpdateBuildParameterCommand
    {
        private readonly ITeamcityService _teamcityService;

        public UpdateBuildParameterCommand(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }
        public async Task<string> Execute(Build build, string parameter, string value)
        {
            return await _teamcityService.UpdateBuildParameter(build.Id, parameter, value);
        }
    }
}
