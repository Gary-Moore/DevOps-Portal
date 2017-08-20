using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.UpdateBuildParameter
{
    public interface IUpdateBuildParameterCommand
    {
        Task<string> Execute(Build build, string parameter, string value);
    }
}