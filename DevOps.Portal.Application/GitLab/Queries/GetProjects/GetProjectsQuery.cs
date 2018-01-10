using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.GitLab.Queries.GetProjects
{
    public class GetProjectsQuery : IGetProjectsQuery
    {
        private readonly IGitLabService _gitLabService;

        public GetProjectsQuery(IGitLabService gitLabService)
        {
            _gitLabService = gitLabService;
        }

        public async Task<IEnumerable<Project>> Execute(string searchTerm)
        {
            var projects = await _gitLabService.Get();

            return projects;
        }
    }
}
