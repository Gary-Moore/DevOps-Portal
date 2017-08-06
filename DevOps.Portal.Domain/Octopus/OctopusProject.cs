using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Domain.Octopus
{
    public class OctopusProject
    {
        public OctopusProject()
        {
            Group = new OctopusProjectGroup();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string MyProperty { get; set; }
        public OctopusProjectGroup Group { get; set; }
    }
}
