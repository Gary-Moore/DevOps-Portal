using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevOps.Portal.Web.Models.SolutionBuilder
{
    public class CreateSolutionViewModel
    {
        [Display(Name = "Main project name")]
        public string SolutionName { get; set; }

        [Display(Name = "Sub project name")]
        public string SubProjectName { get; set; }

        [Display(Name = "Build Template")]
        public string BuildTemplateName { get; set; }

        [Display(Name = "GitLab Source Url")]
        public string SourceControlUrl { get; set; }
    }
}