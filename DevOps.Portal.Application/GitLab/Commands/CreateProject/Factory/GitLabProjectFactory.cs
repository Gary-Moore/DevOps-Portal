using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateProject.Factory
{
    public class GitLabProjectFactory : IGitLabProjectFactory
    {
        public Project Create(string name, string description, string groupId)
        {
            return new Project()
            {
                Name = name,
                Description = description,
                Visibility = GroupVisibility.Private,
                GroupId = groupId 
            };
        }
    }
}