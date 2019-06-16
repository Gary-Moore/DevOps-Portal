using System.Threading.Tasks;

namespace DevOps.Portal.Core.Application.UltraBuild.Commands
{
    public interface IUltraBuildCommand
    {
        Task ExecuteAsync(UltraBuildModel model);

        Task UndoAsync(UltraBuildModel model);
    }
}