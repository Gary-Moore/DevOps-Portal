using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;

namespace DevOps.Portal.Application.VisualStudio.Commands.DownloadTemplate
{
    public interface ICloneSolutionTemplateCommand
    {
        Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction);
    }
}