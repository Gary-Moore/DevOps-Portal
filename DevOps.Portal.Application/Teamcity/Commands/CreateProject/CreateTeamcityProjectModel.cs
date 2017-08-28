using System;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject
{
    public class CreateTeamcityProjectModel : TeamCityComponent
    {
        public ParentProjectModel ParentProject { get; set; }
    }
}
