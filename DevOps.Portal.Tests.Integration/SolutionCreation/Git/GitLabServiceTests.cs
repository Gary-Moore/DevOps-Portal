using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Domain.GitLab;
using DevOps.Portal.Infrastructure.Git;
using Newtonsoft.Json;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.Git
{
    [TestFixture]
    public class GitLabServiceTests : BaseTest
    {
        private IGitLabService Sut;
        private string _json;
        private Group _group;

        [SetUp]
        public void Setup()
        {
            Sut = Get<IGitLabService>();

        }

        [Test]
        public void CreateGroup_ReturnsSucessfulResult()
        {
            _group = new Group()
            {
                Name = "Divisions",
                Description = "Divisions system",
                Path = "Divisions",
                Visibility = GroupVisibility.Private
            };

            _json = ParseObjectTojson(_group);
            var result = Sut.CreateGroup(_json);
            result.Wait();

            Assert.That(result.Result.Id, Is.Not.Empty);
        }

        [TearDown]
        public void TearDown()
        {
            _json = ParseObjectTojson(_group);
            var result = Sut.DeleteGroup(_json);
            result.Wait();
        }

        private string ParseObjectTojson<T>(T model) where T : class
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
