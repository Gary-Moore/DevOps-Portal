namespace DevOps.Portal.Web.Models.SolutionCreator
{
    public class CreateSolutionViewModel
    {
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