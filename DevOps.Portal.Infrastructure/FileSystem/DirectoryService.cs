using System.IO;

namespace DevOps.Portal.Infrastructure.FileSystem
{
    public class DirectoryService : IDirectoryService
    {
        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.Exists(path) ? new DirectoryInfo(path) : Directory.CreateDirectory(path);
        }

        public void DeleteDirectory(string path)
        {
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                SetAttributes(directory);
                directory.Delete(true);
            }
        }

        private static void SetAttributes(DirectoryInfo directory)
        {
            foreach (var sub in directory.GetDirectories())
            {
                SetAttributes(sub);
            }
            foreach (var file in directory.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
            }
        }
    }
}
