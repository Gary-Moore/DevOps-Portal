using System.IO;

namespace DevOps.Portal.Infrastructure.FileSystem
{
    public class DirectoryService : IDirectoryService
    {
        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.Exists(path) ? new DirectoryInfo(path) : Directory.CreateDirectory(path);
        }
    }
}
