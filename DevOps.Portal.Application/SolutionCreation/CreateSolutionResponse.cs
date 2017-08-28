using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.SolutionCreation
{
    public class CreateSolutionResponse : ActionResponse
    {
        public CreateTeamCitySolutionResponse TeamCityResponse { get; set; }
    }
}
