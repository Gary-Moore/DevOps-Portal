using System.Text;
using System.Web.Mvc;
using DevOps.Portal.Web.Infrastructure;

namespace DevOps.Portal.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding,
            JsonRequestBehavior behavior)
        {
            return new JsonResponse(data, behavior)
            {
                ContentEncoding = contentEncoding,
                ContentType = contentType
            };
        }
    }
}