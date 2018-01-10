using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Git;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DevOps.Portal.Application.GitLab.Commands.CreateProject
{
    public class CreateGitLabProjectCommand : ICreateGitLabProjectCommand
    {
        private readonly IGitLabService _gitLabService;

        public CreateGitLabProjectCommand(IGitLabService gitLabService)
        {
            _gitLabService = gitLabService;
        }

        public async Task<Project> ExecuteAsync(Project project)
        {
            var serializerSettings =
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var json = JsonConvert.SerializeObject(project, serializerSettings);

            return await _gitLabService.Create(json);
        }
    }
}
