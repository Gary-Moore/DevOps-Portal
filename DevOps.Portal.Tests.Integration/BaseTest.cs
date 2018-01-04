using DevOps.Portal.Tests.Integration.DependencyResolution;
using NUnit.Framework;
using StructureMap;

namespace DevOps.Portal.Tests.Integration
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        private IContainer _container;

        [OneTimeSetUp]
        public void SetUp()
        {
            _container = IoC.Initialise();
        }

        protected T Get<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
