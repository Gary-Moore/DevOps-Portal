using System.Threading.Tasks;
using System.Web.Http;
using DevOps.Portal.Application.VisualStudio.Queries.GetTemplates;

namespace DevOps.Portal.Web.Controllers
{
    public class VisualStudioController : ApiController
    {
        private readonly IGetTemplatesQuery _getTemplatesQuery;

        public VisualStudioController(IGetTemplatesQuery getTemplatesQuery)
        {
            _getTemplatesQuery = getTemplatesQuery;
        }


        [Route("api/visual-studio/templates")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await _getTemplatesQuery.ExecuteAsync();
            return Json(result);
        }
    }
}
