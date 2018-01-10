using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateGroup
{
    public interface ICreateGitLabGroupCommand
    {
        Task<Group> ExecuteAsync(Group project);
    }
}