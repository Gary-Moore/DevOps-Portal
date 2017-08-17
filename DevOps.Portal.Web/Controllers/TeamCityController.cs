using System.Threading.Tasks;
using System.Web.Mvc;
using DevOps.Portal.Application.Teamcity.Queries.GetBuildTemplates;
using DevOps.Portal.Application.Teamcity.Queries.GetProjectsTemplates;

namespace DevOps.Portal.Web.Controllers
{
    public class TeamCityController : Controller
    {
        private readonly IGetBuildTemplatesQuery _getBuildTemplatesQuery;
        private readonly IGetProjectsQuery _getProjectsQuery;

        public TeamCityController(IGetBuildTemplatesQuery getBuildTemplatesQuery, IGetProjectsQuery getProjectsQuery)
        {
            _getBuildTemplatesQuery = getBuildTemplatesQuery;
            _getProjectsQuery = getProjectsQuery;
        }

        [HttpGet]
        public async Task<ActionResult> BuildTemplates()
        {
            var buildTypes = await _getBuildTemplatesQuery.Execute();

            return Json(buildTypes, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> Projects()
        {
            var projects = await _getProjectsQuery.Execute();

            return Json(projects, JsonRequestBehavior.AllowGet);
        }
    }
}