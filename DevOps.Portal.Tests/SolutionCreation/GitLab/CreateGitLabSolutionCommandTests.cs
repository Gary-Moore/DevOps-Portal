using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.GitLab.Commands.CreateGroup;
using DevOps.Portal.Application.GitLab.Commands.CreateSolution;
using DevOps.Portal.Application.SolutionCreation;
using FakeItEasy;
using NUnit.Framework;

namespace DevOps.Portal.Tests.SolutionCreation.GitLab
{
    [TestFixture]
    public class CreateGitLabSolutionCommandTests
    {
        private CreateGitLabSolutionCommand Sut;
        private CreateSolutionModel createModel;
        private ICreateGitLabGroupCommand _createGitLabGroupCommand;

        [SetUp]
        public void Setup()
        {
            _createGitLabGroupCommand = A.Fake<ICreateGitLabGroupCommand>();
            Sut = new CreateGitLabSolutionCommand(_createGitLabGroupCommand);
        }

        [Test]
        public void ExecuteCommand_ReturnsGroup()
        {
            var task = Sut.ExecuteAsync(createModel, NotifyAction);
            task.Wait();

            var result = task.Result;

            Assert.That(result.Group, Is.Not.Null);
        }

        private void NotifyAction(CreateSolutionModel model, string message)
        {
            
        }
    }
}
