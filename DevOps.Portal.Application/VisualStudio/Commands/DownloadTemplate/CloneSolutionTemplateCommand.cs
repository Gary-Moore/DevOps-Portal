using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Queries.GetTemplates;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate
{
    public class CloneSolutionTemplateCommand : ICloneSolutionTemplateCommand
    {
        private readonly IGitService _gitService;
        private readonly IGetTemplateByIdQuery _getTemplateByIdQuery;

        public CloneSolutionTemplateCommand(IGitService gitService, IGetTemplateByIdQuery getTemplateByIdQuery)
        {
            _gitService = gitService;
            _getTemplateByIdQuery = getTemplateByIdQuery;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            var template = await _getTemplateByIdQuery.ExecuteAsync(model.SolutionTemplateId);

            await _gitService.CloneProjectAsync(template.RepositoryUrl, (s) => {});
            
            return new ActionResponse();
        }
    }
}
