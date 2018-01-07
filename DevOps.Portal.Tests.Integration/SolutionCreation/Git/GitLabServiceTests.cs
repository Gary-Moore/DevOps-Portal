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
        private Project _project;
        private string _groupId;
        private string _projectId;

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
            _groupId = result.Result.Id;

            Assert.That(_groupId, Is.Not.Empty);
        }

        [Test]
        public void CreateProject_ReturnsSucessfulResult()
        {
            _group = new Group()
            {
                Name = "Divisions",
                Description = "Divisions system",
                Path = "Divisions",
                Visibility = GroupVisibility.Private
            };

            _json = ParseObjectTojson(_group);
            var createGroupResult = Sut.CreateGroup(_json);
            createGroupResult.Wait();
            
            _project = new Project()
            {
                Name = "Admin",
                Description = "Divisions Admin system",
                Path = "Admin",
                GroupId = createGroupResult.Result.Id,
                Visibility = GroupVisibility.Private
            };

            _json = ParseObjectTojson(_project);
            var result = Sut.Create(_json);
            result.Wait();
            _projectId = result.Result.Id;

            Assert.That(_groupId, Is.Not.Empty);
        }

        [TearDown]
        public void TearDown()
        {
            var result = Sut.DeleteGroup(_groupId);
            result.Wait();
        }

        private static string ParseObjectTojson<T>(T model) where T : class
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
