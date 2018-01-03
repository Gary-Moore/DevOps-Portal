using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.FileSystem;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Application.VisualStudio.Commands.CreateSolution
{
    public class CreateVisualStudioSolutionCommand : ICreateVisualStudioSolutionCommand
    {
        private readonly IDirectoryService _directoryService;
        private readonly IDownloadTemplateCommand _downloadTemplateCommand;
        private readonly IUpdateSolutionFileNamespacesCommand _updateSolutionFileNamespacesCommand;
        private readonly IConfiguration _configuration;

        public CreateVisualStudioSolutionCommand(IDirectoryService directoryService,
            IDownloadTemplateCommand downloadTemplateCommand,
            IUpdateSolutionFileNamespacesCommand updateSolutionFileNamespacesCommand,
            IConfiguration configuration)
        {
            _directoryService = directoryService;
            _downloadTemplateCommand = downloadTemplateCommand;
            _updateSolutionFileNamespacesCommand = updateSolutionFileNamespacesCommand;
            _configuration = configuration;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            // Clean working directory
            _directoryService.DeleteDirectory(_configuration.WorkingDirectory);
            var directory = _directoryService.CreateDirectory(_configuration.DownloadDirectory);
            // Clone template repository
            await _downloadTemplateCommand.ExecuteAsync(model, notifyAction);
            _directoryService.CopyDirectory(directory.FullName, _configuration.WorkingDirectory);
            await _updateSolutionFileNamespacesCommand.ExecuteAsync(model, notifyAction);

            // download template and unzip into location
            return await _downloadTemplateCommand.ExecuteAsync(model, notifyAction);
        }
    }
}
