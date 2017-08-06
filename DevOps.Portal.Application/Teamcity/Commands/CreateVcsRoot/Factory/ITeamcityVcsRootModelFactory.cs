using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory
{
    public interface ITeamcityVcsRootModelFactory
    {
        VcsRoot Create(string name, string projectId, string vcsFetchUrl);
    }
}