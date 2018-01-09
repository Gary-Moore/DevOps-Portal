using System.Threading.Tasks;
using DevOps.Portal.Application.GitLab.Commands.CreateGroup;
using DevOps.Portal.Application.GitLab.Commands.CreateProject;
using DevOps.Portal.Application.GitLab.Commands.CreateProject.Factory;
using DevOps.Portal.Application.GitLab.Commands.CreateSolution;
using DevOps.Portal.Application.GitLab.Commands.PushToRepository;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Domain.GitLab;
using FakeItEasy;
using NUnit.Framework;

namespace DevOps.Portal.Tests.SolutionCreation.GitLab
{
    [TestFixture]
    public class CreateGitLabSolutionCommandTests
    {
        private CreateGitLabSolutionCommand _sut;

        private ICreateGitLabGroupCommand _createGitLabGroupCommand;
        private ICreateGitLabProjectCommand _createGitLabProjectCommand;
        private IPushToGitLabRepositoryCommand _pushToGitLabRepositoryCommand;
        private IGitLabProjectFactory _gitLabProjectFactory;

        private PushToRepositoryResponse _pushToRepositoryResponse;
        private Project _project;
        private Group _group;
        private CreateSolutionModel _createSolutionModel;

        [SetUp]
        public void Setup()
        {
            _createGitLabGroupCommand = A.Fake<ICreateGitLabGroupCommand>();
            _createGitLabProjectCommand = A.Fake<ICreateGitLabProjectCommand>();
            _pushToGitLabRepositoryCommand = A.Fake<IPushToGitLabRepositoryCommand>();
            _gitLabProjectFactory = A.Fake<IGitLabProjectFactory>();

            _pushToRepositoryResponse = new PushToRepositoryResponse()
            {
                Successful = true
            };

            _group = new Group();
            _project = new Project();
            _createSolutionModel = new CreateSolutionModel();

            A.CallTo(() => _pushToGitLabRepositoryCommand.ExecuteAsync(A<PushToRepositoryRequest>._))
                .Returns(_pushToRepositoryResponse);

            A.CallTo(() => _createGitLabGroupCommand.ExecuteAsync(A<Group>._)).Returns(_group);
            A.CallTo(() => _createGitLabProjectCommand.ExecuteAsync(A<Project>._)).Returns(_project);

            _sut = new CreateGitLabSolutionCommand(_createGitLabGroupCommand, _createGitLabProjectCommand,
                _pushToGitLabRepositoryCommand, _gitLabProjectFactory);
        }

        [Test]
        public void ExecuteCommand_ReturnsGroup()
        {
            var result = ExecuteCommandAsync().Result;

            Assert.That(result.Group, Is.Not.Null);
        }

        [Test]
        public void ExecuteCommand_ReturnsProject()
        {
            var result = ExecuteCommandAsync().Result;

            Assert.That(result.Project, Is.Not.Null);
        }

        [Test]
        public void ExecuteCommand_ExecutesPushToGitLabRepoCommand()
        {
            ExecuteCommandAsync();

            A.CallTo(() => _pushToGitLabRepositoryCommand.ExecuteAsync(A<PushToRepositoryRequest>._))
                .MustHaveHappened(Repeated.Exactly.Once);
        }

        [Test]
        public void ExecuteCommand_ReturnsSuccessfulPushToGitLabResponse()
        {
            var result = ExecuteCommandAsync().Result;

            Assert.That(result.PushToRepositorySuccessful, Is.True);
        }

        private Task<CreateGitLabSolutionResponse> ExecuteCommandAsync()
        {
            var task = _sut.ExecuteAsync(_createSolutionModel, NotifyAction);
            task.Wait();

            return task;
        }
        
        private void NotifyAction(CreateSolutionModel model, string message)
        {
            
        }
    }
}
