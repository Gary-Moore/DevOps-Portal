using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Application.GitLab.Commands.CreateSolution;
using DevOps.Portal.Application.Octopus.Commands.CreateSolution;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Infrastructure.Git;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.Octopus
{

    [TestFixture]
    public class CreateOctopusSolutionCommandTests : BaseTest
    {
        private ICreateOctopusSolutionCommand Sut;
        private CreateSolutionModel _createSolutionModel;
        private IGitLabService _gitLabService;
        private CreateOctopusSolutionResponse _result;

        [SetUp]
        public void Setup()
        {
            Sut = Get<ICreateOctopusSolutionCommand>();
            _createSolutionModel = new CreateSolutionModel()
            {
                OctopusProjectName = "Divisions",
                OctopusGroupId = "ProjectGroups-1",
                OctopusLifeCycleId = "Lifecycles-1"
            };
        }

        [Test]
        public void CreateGitLabSolution_ReturnsSucessfulResult()
        {
            var response = Sut.ExecuteAsync(_createSolutionModel, (m, s) => { });
            response.Wait();

            _result = response.Result;

            Assert.That(_result.Project, Is.Not.Null);
        }

        [TearDown]
        public void TearDown()
        {
            

        }
    }
}
