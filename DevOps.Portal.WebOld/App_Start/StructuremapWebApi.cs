using System.Web.Http;
using DevOps.Portal.Web;
using DevOps.Portal.Web.App_Start;
using DevOps.Portal.Web.DependencyResolution;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(StructuremapWebApi), "Start")]
namespace DevOps.Portal.Web
{
    public class StructuremapWebApi
    {
        public static void Start()
        {
            var container = StructuremapMvc.StructureMapDependencyScope.Container;
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
        }
    }
}