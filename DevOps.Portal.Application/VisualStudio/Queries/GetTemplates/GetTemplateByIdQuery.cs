using System.Threading.Tasks;
using DevOps.Portal.Data;
using DevOps.Portal.Domain.VisualStudio;

namespace DevOps.Portal.Application.VisualStudio.Queries.GetTemplates
{
    public class GetTemplateByIdQuery : IGetTemplateByIdQuery
    {
        private readonly IDevOpsPortalRepository<VisualStudioTemplate> _repository;

        public GetTemplateByIdQuery(IDevOpsPortalRepository<VisualStudioTemplate> repository)
        {
            _repository = repository;
        }

        public async Task<VisualStudioTemplate> ExecuteAsync(string id)
        {
            return await _repository.GetItemAsync(id);
        }
    }
}
