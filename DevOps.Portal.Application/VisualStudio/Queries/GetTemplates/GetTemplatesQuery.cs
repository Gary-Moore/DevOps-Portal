using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevOps.Portal.Data;
using DevOps.Portal.Domain.VisualStudio;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public class GetTemplatesQuery : IGetTemplatesQuery
    {
        private readonly IDevOpsPortalRepository<VisualStudioTemplate> _repository;

        public GetTemplatesQuery(IDevOpsPortalRepository<VisualStudioTemplate> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<VisualStudioTemplate>> ExecuteAsync()
        {
            return await _repository.GetItemsAysnc(WhereFilter);
        }

        private static Expression<Func<VisualStudioTemplate, bool>> WhereFilter
        {
            get { return x => true; }
        }
    }
}
