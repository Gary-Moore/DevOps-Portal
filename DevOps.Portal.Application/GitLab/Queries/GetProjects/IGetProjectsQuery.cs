using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Queries.GetProjects
{
    public interface IGetProjectsQuery
    {
        Task<IEnumerable<Project>> Execute(string searchTerm);
    }
}