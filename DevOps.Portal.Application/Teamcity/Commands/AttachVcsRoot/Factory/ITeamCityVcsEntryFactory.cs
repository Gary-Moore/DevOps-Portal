using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot.Factory
{
    public interface ITeamCityVcsEntryFactory
    {
        VcsRootEntry Create(string vcsRootId);
    }
}