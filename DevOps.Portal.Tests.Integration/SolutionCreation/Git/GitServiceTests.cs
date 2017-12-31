using System.IO;
using DevOps.Portal.Infrastructure.Configuration;
using NUnit.Framework;
using DevOps.Portal.Infrastructure.Git;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.Git
{
    [TestFixture]
    public class GitServiceTests : BaseTest
    {
        private GitService Sut;
        private string _repoUrl;

        [SetUp]
        public void Setup()
        {
            Sut = Get<GitService>();
            _repoUrl = "https://github.com/Gary-Moore/SolutionTemplates.git";
        }

        [Test]
        public void CloneRepo()
        {
            var task = Sut.CloneProject(_repoUrl, s => { });
            task.Wait();

            Assert.That(task.Result.Suceess, Is.True);
            Assert.That(AssertDirectoryExists, "Directory not cloned into working folder");
        }

        [TearDown]
        public void CleanUp()
        {
            var configuration = Get<IConfiguration>();
            var workingDirectory = new DirectoryInfo(configuration.WorkingDirectory);

            if (workingDirectory.Exists)
            {
                SetAttributes(workingDirectory);
                workingDirectory.Delete(true);
            }
        }

        private bool AssertDirectoryExists()
        {
            var configuration = Get<IConfiguration>();
            var workingDirectory = new DirectoryInfo(configuration.WorkingDirectory);

            if (workingDirectory.Exists)
            {
                return workingDirectory.GetFileSystemInfos().Length > 0;
            }

            throw new DirectoryNotFoundException();
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
