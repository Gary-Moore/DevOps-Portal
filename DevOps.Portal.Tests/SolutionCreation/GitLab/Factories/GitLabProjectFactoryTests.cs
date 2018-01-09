using DevOps.Portal.Application.GitLab.Commands.CreateProject.Factory;
using DevOps.Portal.Application.SolutionCreation;
using NUnit.Framework;

namespace DevOps.Portal.Tests.SolutionCreation.GitLab.Factories
{
    [TestFixture]
    public class GitLabProjectFactoryTests
    {
        private IGitLabProjectFactory _sut;
        private CreateSolutionModel _model;
        private string _groupId;

        [SetUp]
        public void Setup()
        {
            _sut = new GitLabProjectFactory();

            _model = new CreateSolutionModel()
            {
                GitLabProjectName = "Divisions Admin",
                GitLabProjectDescription = "Project Description"
            };

            _groupId = "123";
        }

        [Test]
        public void CreateProject_SetsCorrectProjectName()
        {
            var project = _sut.Create(_model.GitLabProjectName, _model.GitLabProjectDescription, _groupId);

            Assert.That(project.Name, Is.EqualTo(_model.GitLabProjectName));
        }

        [Test]
        public void CreateProject_SetsCorrectDescription()
        {
            var project = _sut.Create(_model.GitLabProjectName, _model.GitLabProjectDescription, _groupId);

            Assert.That(project.Description, Is.EqualTo(_model.GitLabProjectDescription));
        }

        [Test]
        public void CreateProject_SetsCorrectGroup()
        {
            var project = _sut.Create(_model.GitLabProjectName, _model.GitLabProjectDescription, _groupId);

            Assert.That(project.GroupId, Is.EqualTo(_groupId));
        }
    }
}
