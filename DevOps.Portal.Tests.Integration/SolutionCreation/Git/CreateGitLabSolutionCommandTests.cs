using DevOps.Portal.Application.GitLab.Commands.CreateSolution;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Infrastructure.Git;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.Git
{
    [TestFixture]
    public class CreateGitLabSolutionCommandTests : BaseTest
    {
        private ICreateGitLabSolutionCommand Sut;
        private CreateSolutionModel _createSolutionModel;
        private IGitLabService _gitLabService;
        private CreateGitLabSolutionResponse _result;

        [SetUp]
        public void Setup()
        {
            Sut = Get<ICreateGitLabSolutionCommand>();
            _createSolutionModel = new CreateSolutionModel()
            {
                VisualStudioSolutionName = "Divisions",
                VisualStudioSubprojectName = "Admin",
                GitLabProjectName = "Divisions Admin App",
                GitLabGroupName = "Divisions",
                GitLabGroupPath = "divisions",
                GitLabProjectDescription = "Divisions Admin Application"
            };
        }

        [Test]
        public void CreateGitLabSolution_ReturnsSucessfulResult()
        {
            var response = Sut.ExecuteAsync(_createSolutionModel, (m, s) => { });
            response.Wait();

            _result = response.Result;
            
            Assert.That(_result.PushToRepositorySuccessful, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            _gitLabService = Get<IGitLabService>();

            if (string.IsNullOrEmpty(_result.Group.Id))
            {
                var result = _gitLabService.DeleteGroup(_result.Group.Id);
                result.Wait();
            }

        }
    }
}
