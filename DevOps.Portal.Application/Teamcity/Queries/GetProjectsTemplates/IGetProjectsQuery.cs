using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetProjectsTemplates
{
    public interface IGetProjectsQuery
    {
        Task<IEnumerable<Project>> Execute();
    }
}