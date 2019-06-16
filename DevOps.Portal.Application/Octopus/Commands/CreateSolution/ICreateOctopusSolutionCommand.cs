using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;

namespace DevOps.Portal.Application.Octopus.Commands.CreateSolution
{
    public interface ICreateOctopusSolutionCommand
    {
        Task<CreateOctopusSolutionResponse> ExecuteAsync(CreateSolutionModel model,
            Action<CreateSolutionModel, string> notifyAction);
    }
}