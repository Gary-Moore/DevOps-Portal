using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Compute.Fluent;

namespace DevOps.Portal.Core.Infrastructure.AzureResources
{
    public interface IAzureService
    {
        Task<IEnumerable<IVirtualMachine>> GetList();
    }
}