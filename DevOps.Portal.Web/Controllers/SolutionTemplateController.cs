using DevOps.Portal.Application.VisualStudio.Queries.GetTemplates;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevOps.Portal.Web.Controllers
{
    public class SolutionTemplateController : BaseController
    {
        private readonly IGetTemplatesQuery _getTemplatesQuery;

        public SolutionTemplateController(IGetTemplatesQuery getTemplatesQuery)
        {
            _getTemplatesQuery = getTemplatesQuery;
        }

        [HttpGet]
        public async Task<ActionResult> Templates()
        {
            var templates = await _getTemplatesQuery.ExecuteAsync();

            return Json(templates, JsonRequestBehavior.AllowGet);
        }
    }
}