using System.Collections.Generic;

namespace DevOps.Portal.Domain.Teamcity
{
    public class VcsRoot : TeamCityComponent
    {
        public string VcsName { get; set; }

        public Project Project { get; set; }

        public VcsProperites Properties { get; set; }
    }
}
