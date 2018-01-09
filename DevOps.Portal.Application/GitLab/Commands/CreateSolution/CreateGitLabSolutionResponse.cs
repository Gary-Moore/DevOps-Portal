using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateSolution
{
    public class CreateGitLabSolutionResponse
    {
        public Group Group { get; set; }

        public Project Project { get; set; }

        public bool PushToRepositorySuccessful { get; set; }
    }
}
