using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateBuild
{
    public class CreateBuildCommand : ICreateBuildCommand
    {
        private readonly ITeamcityService _teamcityService;

        public CreateBuildCommand(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public async Task<Build> ExecuteAsync(string projectId)
        {
            var build = await _teamcityService.CreateBuildAsync("CI", projectId);
            return await _teamcityService.UpdateBuildTemplateAsync(build.Id, "Ci");
        }
    }
}
