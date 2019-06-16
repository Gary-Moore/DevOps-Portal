namespace DevOps.Portal.Core.Application.UltraBuild
{
    public class UltraBuildModel
    {
        public UltraBuildModel()
        {
            VisualStudio = new CreateVisualStudioSolution();
        }

        public CreateGitLabProject GitLab { get; set; }
        public CreateVisualStudioSolution VisualStudio { get; set; }
        public CreateOctopusProject Octopus { get; set; }   
    }
}
