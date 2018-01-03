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
        private readonly IDevOpsPortalRepository<SolutionTemplate> _repository;

        public GetTemplatesQuery(IDevOpsPortalRepository<SolutionTemplate> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SolutionTemplate>> ExecuteAsync()
        {
            return await _repository.GetItemsAysnc(WhereFilter);
        }

        private static Expression<Func<SolutionTemplate, bool>> WhereFilter
        {
            get { return x => true; }
        }
    }
}
