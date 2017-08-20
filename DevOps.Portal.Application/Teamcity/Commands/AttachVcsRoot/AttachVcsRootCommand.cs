using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot.Factory;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot
{
    public class AttachVcsRootCommand : IAttachVcsRootCommand
    {
        private readonly ITeamcityService _teamcityService;
        private readonly ITeamCityVcsEntryFactory _teamCityVcsEntryFactory;

        public AttachVcsRootCommand(ITeamcityService teamcityService, ITeamCityVcsEntryFactory teamCityVcsEntryFactory)
        {
            _teamcityService = teamcityService;
            _teamCityVcsEntryFactory = teamCityVcsEntryFactory;
        }

        public Task<VcsRoot> Execute(string vcsRootId, string buildId)
        {
            var model = _teamCityVcsEntryFactory.Create(vcsRootId);

            var serializerSettings =
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                };
            var json = JsonConvert.SerializeObject(model, serializerSettings);

            return _teamcityService.AttachVcsRoot(json, buildId);
        }
    }
}
