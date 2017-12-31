using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.VisualStudio;
using DevOps.Portal.Infrastructure.TableStore;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public class GetTemplatesQuery : IGetTemplatesQuery
    {
        private readonly ISolutionTemplateService _solutionTemplateService;

        public GetTemplatesQuery(ISolutionTemplateService solutionTemplateService)
        {
            _solutionTemplateService = solutionTemplateService;
        }

        public async Task<IEnumerable<SolutionTemplate>> ExecuteAsync()
        {
            return await Task.Run(() =>_solutionTemplateService.Get());
        }
    }
}
