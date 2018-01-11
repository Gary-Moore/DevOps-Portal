using System.Threading.Tasks;
using Octopus.Client.Model;

namespace DevOps.Portal.Application.Octopus.Commands.CreateProject
{
    public interface ICreateOctopusProjectCommand
    {
        Task<ProjectResource> ExecuteAsync(ProjectResource project);
    }
}