using System.Threading.Tasks;
using DevOps.Portal.Data;
using DevOps.Portal.Domain.VisualStudio;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public class GetTemplateByIdQuery : IGetTemplateByIdQuery
    {
        private readonly IDevOpsPortalRepository<SolutionTemplate> _repository;

        public GetTemplateByIdQuery(IDevOpsPortalRepository<SolutionTemplate> repository)
        {
            _repository = repository;
        }

        public async Task<SolutionTemplate> ExecuteAsync(string id)
        {
            return await _repository.GetItemAsync(id);
        }
    }
}
