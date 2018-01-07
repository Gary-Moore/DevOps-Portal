using System.Collections.Generic;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;

namespace DevOps.Portal.Infrastructure.Git
{
    public interface IGitLabService
    {
        Task<Project> Create(string createProjectJson);

        Task<Project> Update(string updateProjectJson);

        Task<Project> GetById(string id);

        Task<IEnumerable<Project>> Get();

        Task<Group> CreateGroup(string createGroupJson);

        Task<Group> UpdateGroup(string updateGroupJson);

        Task<bool> DeleteGroup(string deleteGroupJson);
    }
}