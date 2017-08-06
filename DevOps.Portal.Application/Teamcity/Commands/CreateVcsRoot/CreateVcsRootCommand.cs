using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot
{
    public class CreateVcsRootCommand : ICreateVcsRootCommand
    {
        private readonly ITeamcityService _teamcityService;
        private readonly IAttachVcsRootCommand _attachVcsRootCommand;

        public CreateVcsRootCommand(ITeamcityService teamcityService, IAttachVcsRootCommand attachVcsRootCommand)
        {
            _teamcityService = teamcityService;
            _attachVcsRootCommand = attachVcsRootCommand;
        }

        public async Task<VcsRoot> Execute(VcsRoot vcsRoot, string buildId)
        {
            var serializerSettings =
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                };
            var json = JsonConvert.SerializeObject(vcsRoot, serializerSettings);
            await _teamcityService.CreateVcsRoot(json);
            return await _attachVcsRootCommand.Execute(vcsRoot.Id, buildId);
        }
    }
}
