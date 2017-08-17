using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetBuildTemplates
{
    public interface IGetBuildTemplatesQuery
    {
        Task<IEnumerable<BuildType>> Execute();
    }
}