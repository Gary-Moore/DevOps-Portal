using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Core.Application.UltraBuild.Commands
{
    public class CreateVisualStudioSolutionCommand : IUltraBuildCommand
    {
        private IEnumerable<IUltraBuildCommand> _commands;

        public async Task ExecuteAsync(UltraBuildModel model)
        {
            foreach (var command in _commands)
            {
                await command.ExecuteAsync(model);
            }
        }

        public Task UndoAsync(UltraBuildModel model)
        {
            throw new NotImplementedException();
        }
    }
}
