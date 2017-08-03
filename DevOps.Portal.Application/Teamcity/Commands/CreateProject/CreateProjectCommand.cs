using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Teamcity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject
{
    public class CreateProjectCommand : ICreateProjectCommand
    {
        private readonly ITeamcityService _teamcityService;

        public CreateProjectCommand(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public Task<Project> ExecuteAsync(CreateTeamcityProjectModel model)
        {
            var serializerSettings =
                new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};
            var json = JsonConvert.SerializeObject(model, serializerSettings);

            return _teamcityService.CreateProjectAsync(json);
        }
    }
}