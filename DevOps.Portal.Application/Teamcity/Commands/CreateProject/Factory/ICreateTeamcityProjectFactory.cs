namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject.Factory
{
    public interface ICreateTeamcityProjectFactory
    {
        CreateTeamcityProjectModel Create(string name, string parentName = null);
    }
}