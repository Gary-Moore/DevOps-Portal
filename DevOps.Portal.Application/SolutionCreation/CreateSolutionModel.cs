namespace DevOps.Portal.Application.SolutionCreation
{
    public class CreateSolutionModel
    {
        public string ConnectionId { get; set; }

        public int VisualStudioSolutionType { get; set; }
        public string VisualStudioSolutionName { get; set; }
        public string VisualStudioSubprojectName { get; set; }

        public bool NewParentProject { get; set; }
        public string TeamCityParentProjectId { get; set; }
        public string TeamCityNewParentProjectName { get; set; }
        public string TeamCityParentProjectDescription { get; set; }
        public string TeamCitySubprojectName { get; set; }
        public string TeamCitySubprojectDescription { get; set; }
        public string TeamcityBuildTemplateId { get; set; }
        public string SourceControlUrl { get; set; }
        public string TemplateUrl { get; set; }

        public string SolutionTemplateId { get; set; }

        // GitLab
        public int? GitLabGroupId { get; set; }
        public string GitLabGroupName { get; set; }
        public string GitLabProjectName { get; set; }
        public string GitLabProjectDescription { get; set; }
        public string GitLabGroupPath { get; set; }

        // Octopus
        public string OctopusProjectName { get; set; }
        public string OctopusGroupName { get; set; }
        public string OctopusGroupId { get; set; }
        public string OctopusLifeCycleId { get; set; }
    }
}
