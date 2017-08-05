namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory
{
    public interface ICreateTeamcityVcsRootModelFactory
    {
        CreateTeamcityVcsRootModel Create(string name, string projectId);
    }
}