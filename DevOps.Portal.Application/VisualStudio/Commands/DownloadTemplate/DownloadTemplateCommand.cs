using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate
{
    public class DownloadTemplateCommand : IDownloadTemplateCommand
    {
        private readonly IGitService _gitService;

        public DownloadTemplateCommand(IGitService gitService)
        {
            _gitService = gitService;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            await _gitService.DownloadProjectAsync("https://github.com/Gary-Moore/SolutionTemplates/archive/master.zip", model.TemplateUrl);

            return new ActionResponse();
        }
    }
}
