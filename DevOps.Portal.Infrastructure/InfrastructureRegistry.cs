using DevOps.Portal.Infrastructure.Configuration;
using StructureMap;

namespace DevOps.Portal.Infrastructure
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
            });
            For<IConfiguration>().Use<ConfigurationWrapper>().Singleton();
        }
    }
}
