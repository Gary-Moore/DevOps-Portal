using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate;

namespace DevOps.Portal.Application.VisualStudio.Commands.CreateSolution
{
    public class CreateVisualStudioSolutionCommand : ICreateVisualStudioSolutionCommand
    {
        private readonly IDownloadTemplateCommand _downloadTemplateCommand;

        public CreateVisualStudioSolutionCommand(IDownloadTemplateCommand downloadTemplateCommand)
        {
            _downloadTemplateCommand = downloadTemplateCommand;
        }
        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            return await _downloadTemplateCommand.ExecuteAsync(model, notifyAction);
        }
    }
}
