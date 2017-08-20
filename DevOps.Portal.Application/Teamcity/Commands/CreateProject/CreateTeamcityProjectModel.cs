using System;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject
{
    [Serializable]
    public class CreateTeamcityProjectModel
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public ParentProjectModel ParentProject { get; set; }
    }
}
