using System.Threading.Tasks;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateSolution
{
    public interface ICreateTeamcitySolutionCommand
    {
        Task Execute(string mainProjectName, string subProjectName);
    }
}