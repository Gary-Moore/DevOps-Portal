using StructureMap;

namespace DevOps.Portal.Tests.Integration.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialise()
        {
            return new Container(c =>
            {
                c.AddRegistry<DefaultRepository>();
            });
        }
    }
}
