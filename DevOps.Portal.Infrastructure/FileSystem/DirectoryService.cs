using System.IO;
using System.Linq;

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

        public void CopyDirectory(string sourcePath, string destinationPath)
        {
            var sourceDirectory = new DirectoryInfo(sourcePath);
            if (sourceDirectory.Exists)
            {
                if (!Directory.Exists(destinationPath))
                {
                    CreateDirectory(destinationPath);
                }

                var files = sourceDirectory.GetFiles();
                foreach (var file in files)
                {
                    var destPath = Path.Combine(destinationPath, file.Name);
                    File.Copy(file.FullName, destPath, true);
                }

                var subDirectories = sourceDirectory.GetDirectories().Where(dir => dir.Name != ".git").ToArray();

                foreach (var subDirectory in subDirectories)
                {
                    var subDirectoryDestinationPath = Path.Combine(destinationPath, subDirectory.Name);
                    CopyDirectory(subDirectory.FullName, subDirectoryDestinationPath);
                }
            }
            else
            {
                throw new DirectoryNotFoundException();
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
