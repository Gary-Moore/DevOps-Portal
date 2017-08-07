using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot.Factory
{
    public class TeamCityVcsEntryFactory : ITeamCityVcsEntryFactory
    {
        public VcsRootEntry Create(string vcsRootId)
        {
            return new VcsRootEntry()
            {
                VcsRoot = new VcsRoot()
                {
                    Id = vcsRootId
                }
            };
        }
    }
}
