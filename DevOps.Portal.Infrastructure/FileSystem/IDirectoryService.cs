using System.IO;

namespace DevOps.Portal.Infrastructure.FileSystem
{
    public interface IDirectoryService
    {
        DirectoryInfo CreateDirectory(string path);
    }
}