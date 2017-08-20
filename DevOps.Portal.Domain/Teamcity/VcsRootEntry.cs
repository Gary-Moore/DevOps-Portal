using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DevOps.Portal.Domain.Teamcity
{
    public class VcsRootEntry : TeamCityComponent
    {
        [JsonProperty("vcs-root")]
        public VcsRoot VcsRoot { get; set; }
    }
}
