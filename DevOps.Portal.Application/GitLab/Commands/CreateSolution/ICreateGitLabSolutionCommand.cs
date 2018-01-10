using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;

namespace DevOps.Portal.Application.GitLab.Commands.CreateSolution
{
    public interface ICreateGitLabSolutionCommand
    {
        Task<CreateGitLabSolutionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction);
    }
}