using DevOps.Portal.Domain.VisualStudio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public interface IGetTemplatesQuery
    {
        Task<IEnumerable<SolutionTemplate>> ExecuteAsync();
    }
}