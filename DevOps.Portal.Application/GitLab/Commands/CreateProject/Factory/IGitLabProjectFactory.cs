using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateProject.Factory
{
    public interface IGitLabProjectFactory
    {
        Project Create(string name, string description, string groupId);
    }
}