﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Application.SolutionCreation
{
    public class CreateSolutionModel
    {
        public string ConnectionId { get; set; }

        public int VisualStudioSolutionType { get; set; }
        public string VisualStudioSolutionName { get; set; }
        public string VisualStudioSubprojectName { get; set; }

        public string TeamCityParentProjectId { get; set; }
        public string TeamCityNewParentProjectName { get; set; }
        public string TeamCityParentProjectDescription { get; set; }
        public string TeamCitySubprojectName { get; set; }
        public string TeamCitySubprojectDescription { get; set; }
        public string TeamcityBuildTemplateId { get; set; }
        public string SourceControlUrl { get; set; }
    }
}