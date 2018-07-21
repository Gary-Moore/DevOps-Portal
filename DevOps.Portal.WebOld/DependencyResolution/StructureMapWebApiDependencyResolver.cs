using System.Web.Http.Dependencies;
using StructureMap;

namespace DevOps.Portal.Web.DependencyResolution
{
    public class StructureMapWebApiDependencyResolver : StructureMapWebApiDependencyScope, IDependencyResolver
    {
        public StructureMapWebApiDependencyResolver(IContainer container) : base(container)
        {
        }

        public IDependencyScope BeginScope()
        {
            var child = Container.GetNestedContainer();
            return new StructureMapWebApiDependencyResolver(child);
        }
    }
}