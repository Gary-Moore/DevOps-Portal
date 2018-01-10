using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateGroup.Factory
{
    public interface IGitLabGroupFactory
    {
        Group Create(string name, string path);
    }
}