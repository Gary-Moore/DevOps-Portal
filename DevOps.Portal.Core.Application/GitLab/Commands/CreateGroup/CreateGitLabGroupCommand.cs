using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Core.Application.UltraBuild;
using DevOps.Portal.Core.Application.UltraBuild.Commands;

namespace DevOps.Portal.Core.Application.GitLab.Commands.CreateGroup
{
    public class CreateGitLabGroupCommand : IUltraBuildCommand
    {
        public Task ExecuteAsync(UltraBuildModel model)
        {
            throw new NotImplementedException();
        }

        public Task UndoAsync(UltraBuildModel model)
        {
            throw new NotImplementedException();
        }
    }
}
