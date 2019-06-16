using DevOps.Portal.Core.Application.UltraBuild;
using Microsoft.AspNetCore.Mvc;

namespace DevOps.Portal.Web.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UltraBuildController : ControllerBase
    {
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Put([FromBody] UltraBuildModel model)
        {
            return Ok("Solution built");
        }
    }
}
