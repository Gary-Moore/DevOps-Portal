using System.Threading.Tasks;
using Octopus.Client.Model;

namespace DevOps.Portal.Infrastructure.Octopus
{
    public interface IOctopusService
    {
        Task<ProjectGroupResource> CreateGroupAsync(ProjectGroupResource group);
        Task<ProjectResource> CreateProjectAsync(ProjectResource project);
    }
}