using System.Collections.Generic;

namespace DevOps.Portal.Domain.Teamcity
{
    public class VcsProperites
    {
        public int Count { get; set; }
        public IEnumerable<VcsProperty> Property { get; set; }
    }
}
