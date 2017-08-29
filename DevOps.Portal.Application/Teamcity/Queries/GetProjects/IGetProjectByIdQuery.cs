using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Queries.GetProjects
{
    public interface IGetProjectByIdQuery
    {
        Task<Project> Execute(string id);
    }
}