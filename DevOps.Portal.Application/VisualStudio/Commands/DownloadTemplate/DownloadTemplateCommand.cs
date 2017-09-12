using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate
{
    public class DownloadTemplateCommand : IDownloadTemplateCommand
    {
        private readonly IGitHubService _gitHubService;

        public DownloadTemplateCommand(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            await _gitHubService.DownloadProjectAsync("https://github.com/Gary-Moore/SolutionTemplates/archive/master.zip", model.TemplateUrl);

            return new ActionResponse();
        }
    }
}
