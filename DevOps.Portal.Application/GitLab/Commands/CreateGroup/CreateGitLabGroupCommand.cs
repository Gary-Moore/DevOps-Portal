using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Git;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.GitLab.Commands.CreateGroup
{
    public class CreateGitLabGroupCommand : ICreateGitLabGroupCommand
    {
        private readonly IGitLabService _gitLabService;

        public CreateGitLabGroupCommand(IGitLabService gitLabService)
        {
            _gitLabService = gitLabService;
        }

        public async Task<Group> ExecuteAsync(Group project)
        {
            var serializerSettings =
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(project, serializerSettings);

            return await _gitLabService.CreateGroup(json);
        }
    }
}
