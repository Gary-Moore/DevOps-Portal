using DevOps.Portal.Domain.Teamcity;
using System.Collections.Generic;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot.Factory
{
    public class TeamcityVcsRootModelFactory : ITeamcityVcsRootModelFactory
    {
        public VcsRoot Create(string name, string projectId, string vcsFetchUrl)
        {
            return new VcsRoot()
            {
                Name = name,
                VcsName = "jetbrains.git",
                Project = new Project()
                {
                    Id = projectId
                },

                Properties = CreateProperties(vcsFetchUrl)
            };
        }

        private VcsProperites CreateProperties(string vcsFetchUrl)
        {
            return new VcsProperites()
            {
                Property = new List<VcsProperty>()
                {
                    new VcsProperty()
                    {
                        Name = "url",
                        Value = vcsFetchUrl
                    },
                    new VcsProperty()
                    {
                        Name = "branch",
                        Value = "refs/heads/master"
                    }
                }
            };
        }
    }
}
