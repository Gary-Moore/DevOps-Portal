using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Application.GitLab.Commands.CreateProject
{
    public interface ICreateGitLabProjectCommand
    {
        Task<Project> ExecuteAsync(Project project);
    }
}