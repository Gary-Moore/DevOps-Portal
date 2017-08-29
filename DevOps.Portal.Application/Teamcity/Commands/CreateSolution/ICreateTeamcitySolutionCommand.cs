using System;
using System.Threading.Tasks;
using DevOps.Portal.Application.SolutionCreation;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public interface ICreateTeamcitySolutionCommand
    {
        Task<CreateTeamCitySolutionResponse> ExecuteAsync(CreateSolutionModel model, Action<CreateSolutionModel, string> notifyAction);

    }
}