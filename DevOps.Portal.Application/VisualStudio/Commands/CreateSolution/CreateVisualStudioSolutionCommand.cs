using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.FileSystem;

namespace DevOps.Portal.Application.VisualStudio.Commands.CreateSolution
{
    public class CreateVisualStudioSolutionCommand : ICreateVisualStudioSolutionCommand
    {
        private readonly IDirectoryService _directoryService;
        private readonly IDownloadTemplateCommand _downloadTemplateCommand;
        private readonly IConfiguration _configuration;

        public CreateVisualStudioSolutionCommand(IDirectoryService directoryService,
            IDownloadTemplateCommand downloadTemplateCommand,
            IConfiguration configuration)
        {
            _directoryService = directoryService;
            _downloadTemplateCommand = downloadTemplateCommand;
            _configuration = configuration;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            // Clean working directory
            _directoryService.DeleteDirectory(_configuration.WorkingDirectory);
            var directory = _directoryService.CreateDirectory(_configuration.WorkingDirectory);


            // download template and unzip into location
            return await _downloadTemplateCommand.ExecuteAsync(model, notifyAction);
        }
    }
}
