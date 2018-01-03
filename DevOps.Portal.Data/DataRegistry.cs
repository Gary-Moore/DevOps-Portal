using StructureMap;

namespace DevOps.Portal.Data
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
            });

            For(typeof(IDevOpsPortalRepository<>)).Use(typeof(DevOpsPortalRepository<>));
        }
    }
}
