using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public class CreateTeamCitySolutionResponse
    {
        public Project ParentProject { get; set; }
        public Project SubProject { get; set; }
        public VcsRoot TypVcsRoot { get; set; }
    }
}
