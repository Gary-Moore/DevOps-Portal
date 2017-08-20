using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject
{
    public interface ICreateProjectCommand
    {
        Task<Project> ExecuteAsync(CreateTeamcityProjectModel model);
    }
}