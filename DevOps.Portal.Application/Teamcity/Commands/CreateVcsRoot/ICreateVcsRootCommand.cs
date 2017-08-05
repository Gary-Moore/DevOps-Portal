using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot
{
    public interface ICreateVcsRootCommand
    {
        Task<VcsRoot> Execute(CreateTeamcityVcsRootModel rootUrl);
    }
}