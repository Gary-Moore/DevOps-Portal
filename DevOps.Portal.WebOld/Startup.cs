using System.Web.Mvc;
using DevOps.Portal.WebOld;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using IDependencyResolver = Microsoft.AspNet.SignalR.IDependencyResolver;

[assembly: OwinStartup(typeof(Startup))]
namespace DevOps.Portal.WebOld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var resolver = DependencyResolver.Current.GetService<IDependencyResolver>();
            app.MapSignalR();

            var hubConfiguration = new HubConfiguration()
            {
                Resolver = resolver
            };

            app.MapSignalR(hubConfiguration);
        }
    }
}