using DevOps.Portal.Domain.VisualStudio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevOps.Portal.Infrastructure.TableStore
{
    public interface ISolutionTemplateService
    {
        IEnumerable<SolutionTemplate> Get();
    }
}