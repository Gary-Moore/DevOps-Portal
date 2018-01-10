using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.GitLab.Queries.GetProjects
{
    public class GetProjectByIdQuery : IGetProjectByIdQuery
    {
        private readonly IGitLabService _gitLabService;

        public GetProjectByIdQuery(IGitLabService gitLabService)
        {
            _gitLabService = gitLabService;
        }

        public async Task<Project> Execute(string id)
        {
            return await _gitLabService.GetById(id);
        }
    }
}