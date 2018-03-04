using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.VisualStudio;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public interface IGetTemplateByIdQuery
    {
        Task<VisualStudioTemplate> ExecuteAsync(string id);
    }
}