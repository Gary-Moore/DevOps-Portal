using StructureMap;

namespace DevOps.Portal.Tests.Integration.DependencyResolution
{
    public class DefaultRepository : Registry
    {
        public DefaultRepository()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.AssembliesFromApplicationBaseDirectory();
                    scan.LookForRegistries();
                });
        }
    }
}
