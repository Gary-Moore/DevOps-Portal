using DevOps.Portal.Infrastructure.AzureManagement;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.AzureManagement
{
    [TestFixture]
    public class AzureServiceTests : BaseTest
    {
        private IAzureDeploymentService _sut;

        [SetUp]
        public void Setup()
        {
            _sut = Get<IAzureDeploymentService>();
        }

        [Test]
        public void DeployTemplate()
        {
            var response = _sut.DeployTemplate();
            response.Wait();

            Assert.That(true);
        }
    }
}
