using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateGroup.Factory
{
    public class GitLabGroupFactory : IGitLabGroupFactory
    {
        public Group Create(string name, string path)
        {
            return new Group()
            {
                Name = name,
                Path = path,
                Description = name,
                Visibility = GroupVisibility.Private
            };
        }
    }
}