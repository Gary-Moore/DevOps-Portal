using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot
{
    public class CreateVcsRootCommand : ICreateVcsRootCommand
    {
        private readonly ITeamcityService _teamcityService;

        public CreateVcsRootCommand(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public Task<VcsRoot> Execute(CreateTeamcityVcsRootModel model)
        {
            var serializerSettings =
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                };
            var json = JsonConvert.SerializeObject(model, serializerSettings);
            return _teamcityService.CreateVcsRoot(json);
        }
    }
}
