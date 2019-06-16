using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.SolutionCreation.Commands;
using DevOps.Portal.Application.SolutionCreation.Validation;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.WebOld.Controllers;
using FakeItEasy;
using NUnit.Framework;

namespace DevOps.Portal.Tests.SolutionCreation
{
    [TestFixture]
    public class SolutionCreationControllerTests
    {
        private SolutionCreatorController _sut;
        
        private ICreateSolutionCommand _mockCreateSolutionCommand;
        private IValidationEngine _mockValidationEngine;

        [SetUp]
        public void Setup()
        {
            _mockCreateSolutionCommand = A.Fake<ICreateSolutionCommand>();
            _mockValidationEngine = A.Fake<IValidationEngine>();
            _sut = new SolutionCreatorController(_mockCreateSolutionCommand, _mockValidationEngine);
        }

        [Test]
        public void CreateTeamCitySolution_TeamCityExceptionThrown_ReturnsErrorsToView()
        {
            IEnumerable<string> errors = new List<string>(){"An error occurred"};

            A.CallTo(() => _mockCreateSolutionCommand.ExecuteAsync(A<CreateSolutionModel>._,
                    A<Action<CreateSolutionModel, string>>._))
                .Throws(() => new TeamCityOperationException(errors));

            var result = _sut.Create(new CreateSolutionModel()).Result as ViewResult;


            var model = result.ViewBag.Error as IEnumerable<string>;

            Assert.That(model.Count(), Is.GreaterThan(0));
        }
    }
}
