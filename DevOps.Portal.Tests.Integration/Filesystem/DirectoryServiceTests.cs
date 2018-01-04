using System.IO;
using System.Linq;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.FileSystem;
using DevOps.Portal.Infrastructure.Git;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.Filesystem
{
    [TestFixture]
    public class DirectoryServiceTests : BaseTest
    {
        private IDirectoryService Sut;
        private string _sourceDirectory;
        private string _destinationDirectory;

        [SetUp]
        public void Setup()
        {
            Sut = Get<IDirectoryService>();
            var configuration = Get<IConfiguration>();
            _sourceDirectory = configuration.DownloadDirectory;
            _destinationDirectory = configuration.WorkingDirectory;
            Sut.CreateDirectory(_sourceDirectory);

            var gitService = Get<IGitService>();
            var _repoUrl = "https://github.com/Gary-Moore/SolutionTemplates.git";
            var task = gitService.CloneProjectAsync(_repoUrl, s => { });
            task.Wait();
        }

        [Test]
        public void CopyFolderToAnotherLocationCopiesAllFiles()
        {
            var originalFileCount = GetFileCountFromDirectory(_sourceDirectory);

            Sut.CopyDirectory(_sourceDirectory, _destinationDirectory);

            Assert.That(AssertFilesCountIsExpected(_destinationDirectory, originalFileCount));
        }

        [TearDown]
        public void CleanUp()
        {
            Sut.DeleteDirectory(_destinationDirectory);
            Sut.DeleteDirectory(_sourceDirectory);
        }

        private static int GetFileCountFromDirectory(string path)
        {
            var directory = new DirectoryInfo(path);

            if (directory.Exists)
            {
                return directory.GetFileSystemInfos().Count(dir => dir.Name != ".git");
            }

            throw new DirectoryNotFoundException();
        }

        private static bool AssertFilesCountIsExpected(string path, int expectedFileCount)
        {
            var fileCount = GetFileCountFromDirectory(path);

            return fileCount == expectedFileCount;
        }
    }
}
