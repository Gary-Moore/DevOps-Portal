using System.Collections.Generic;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateVcsRoot
{
    public class CreateTeamcityVcsRootModel
    {
        public string Name { get; set; }

        public string VcsName { get; set; }

        public Project Project { get; set; }

        public IEnumerable<VcsProperty> Properties { get; set; }
    }
}
