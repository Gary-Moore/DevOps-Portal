using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Core.Application.UltraBuild.Commands
{
    public class CreateGitLabSolutionCommand : IUltraBuildCommand
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
