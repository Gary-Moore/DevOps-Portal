using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.AzureManagement
{
    public interface IAzureDeploymentService
    {
        Task DeployTemplate();
    }
}