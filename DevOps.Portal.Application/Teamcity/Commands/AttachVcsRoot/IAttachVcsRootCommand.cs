using System.Threading.Tasks;
using DevOps.Portal.Domain.Teamcity;

namespace DevOps.Portal.Application.Teamcity.Commands.AttachVcsRoot
{
    public interface IAttachVcsRootCommand
    {
        Task<VcsRoot> Execute(string vcsRootId, string buildId);
    }
}