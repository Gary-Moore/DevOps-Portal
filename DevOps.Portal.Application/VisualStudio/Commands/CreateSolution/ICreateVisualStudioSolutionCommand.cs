using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;

namespace DevOps.Portal.Application.VisualStudio.Commands.CreateSolution
{
    public interface ICreateVisualStudioSolutionCommand
    {
        Task<ActionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction);
    }
}