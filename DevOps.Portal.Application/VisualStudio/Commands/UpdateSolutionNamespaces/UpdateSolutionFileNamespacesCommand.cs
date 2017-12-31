using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Scripts;

namespace DevOps.Portal.Application.VisualStudio.Commands.UpdateSolutionNamespaces
{
    public class UpdateSolutionFileNamespacesCommand : IUpdateSolutionFileNamespacesCommand
    {
        private readonly IConfiguration _configuration;

        public UpdateSolutionFileNamespacesCommand(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction)
        {
            var cloneProjectScript = new PowershellScript("Convert-Solution.ps1", s => {});
            cloneProjectScript.AddArgument("solutionName", model.VisualStudioSolutionName);
            cloneProjectScript.AddArgument("projectName", model.VisualStudioSubprojectName);
            cloneProjectScript.AddArgument("workingDirPath", _configuration.WorkingDirectory);

            var result = await Task.Run(() => cloneProjectScript.ExecuteAync());
            return new ActionResponse();
        }
    }
}
