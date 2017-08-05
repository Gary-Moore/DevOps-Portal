using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory
{
    public class CreateTeamcityVcsRootModelFactory : ICreateTeamcityVcsRootModelFactory
    {
        public CreateTeamcityVcsRootModel Create(string name, string projectId)
        {
            return new CreateTeamcityVcsRootModel()
            {
                Name = name,
                VcsName = "git",
                Project = new Project()
                {
                    Id = projectId
                },
                Properties = new []
                {
                    new VcsProperty()
                    {
                        Name = "url",
                        Value = "https://github.com/Gary-Moore/VetSurgery"
                    } 
                }
            };
        }
    }
}
