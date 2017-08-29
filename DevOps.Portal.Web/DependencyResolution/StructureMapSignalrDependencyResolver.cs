using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using StructureMap;

namespace DevOps.Portal.Web.DependencyResolution
{
    public class StructureMapSignalrDependencyResolver : DefaultDependencyResolver
    {
        private readonly IContainer _container;

        public StructureMapSignalrDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public override object GetService(Type serviceType)
        {
            return _container.TryGetInstance(serviceType) ?? base.GetService(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances(serviceType).Cast<object>().Concat(base.GetServices(serviceType));
        }
    }
}