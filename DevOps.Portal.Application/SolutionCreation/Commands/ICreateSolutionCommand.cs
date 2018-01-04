using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;

namespace DevOps.Portal.Application.SolutionCreation.Commands
{
    public interface ICreateSolutionCommand
    {
        Task<CreateSolutionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction);
    }
}