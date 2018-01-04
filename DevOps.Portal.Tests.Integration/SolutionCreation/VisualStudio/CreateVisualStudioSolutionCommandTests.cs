using System.IO;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.VisualStudio.Commands.CreateSolution;
using DevOps.Portal.Infrastructure.Configuration;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.VisualStudio
{
    [TestFixture]
    public class CreateVisualStudioSolutionCommandTests : BaseTest
    {
        private ICreateVisualStudioSolutionCommand _sut;
        private IConfiguration _configuration;
        private CreateSolutionModel _createSolutionModel;
        private const string GitRepoUrl = "https://github.com/Gary-Moore/SolutionTemplates.git";

        [SetUp]
        public void Setup()
        {
            _sut = Get<ICreateVisualStudioSolutionCommand>();
            _configuration = Get<IConfiguration>();

        }

        [Test]
        public void ExecuteCommand_ReturnsSuccessfulResult()
        {
            _createSolutionModel = new CreateSolutionModel()
            {
                VisualStudioSolutionName = "Divisions",
                VisualStudioSubprojectName = "Admin"
            };

            _sut.ExecuteAsync(_createSolutionModel, (model, s) => { });

            Assert.That(AssertDirectoryExists);
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
    }
}
