using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.CreateBuild
{
    public interface ICreateBuildCommand
    {
        Task<Build> ExecuteAsync(string name);
    }
}
