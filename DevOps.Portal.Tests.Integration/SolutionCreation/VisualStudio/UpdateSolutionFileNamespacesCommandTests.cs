using System.IO;
using System.Linq;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.UpdateSolutionNamespaces;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.FileSystem;
using DevOps.Portal.Infrastructure.Git;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.VisualStudio
{
    [TestFixture]
    public class UpdateSolutionFileNamespacesCommandTests : BaseTest
    {
        private UpdateSolutionFileNamespacesCommand _Sut;
        private IConfiguration _configuration;
        private CreateSolutionModel _createSolutionModel;
        private const string GitRepoUrl = "https://github.com/Gary-Moore/SolutionTemplates.git";

        [SetUp]
        public void Setup()
        {
            _Sut = Get<UpdateSolutionFileNamespacesCommand>();
            _configuration = Get<IConfiguration>();

            CloneTestGitRepo();
        }
        
        [Test]
        public void UpdateNamespacesInFiles_ReturnsSuccessfullFlag()
        {
            var expectedSolutionFileName = "Divisions.Admin.sln";
            _createSolutionModel = new CreateSolutionModel()
            {
                VisualStudioSolutionName = "Divisions",
                VisualStudioSubprojectName = "Admin"
            };

            var result = _Sut.ExecuteAsync(_createSolutionModel, (s, m) => { });
            result.Wait();

            Assert.That(result.Result.Success, Is.True, "The update script failed to execute: {0}", result.Result.Errors.FirstOrDefault());
            Assert.That(AssertFileHasBeenRenamed(expectedSolutionFileName));
        }

        [TearDown]
        public void CleanUp()
        {
            var directoryService = Get<IDirectoryService>();
            directoryService.DeleteDirectory(_configuration.WorkingDirectory);
        }

        private bool AssertFileHasBeenRenamed(string fileName)
        {
            var configuration = Get<IConfiguration>();
            var path = Path.Combine(configuration.WorkingDirectory, "Solution");
            var workingDirectory = new DirectoryInfo(path);

            if (workingDirectory.Exists)
            {
                return workingDirectory.GetFileSystemInfos().Any(f => f.Name == fileName);
            }

            throw new FileNotFoundException();
        }

        private void CloneTestGitRepo()
        {
            var gitService = Get<IGitService>();
            var cloneTask = gitService.CloneProjectAsync(GitRepoUrl, s => { });
            cloneTask.Wait();
        }
    }
}
