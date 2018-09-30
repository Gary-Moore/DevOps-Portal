using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOps.Portal.Core.Domain.Azure;
using DevOps.Portal.Core.Infrastructure.AzureResources;
using Microsoft.AspNetCore.Mvc;

namespace DevOps.Portal.Web.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class VirtualMachinesController : ControllerBase
    {
        private readonly IAzureService _azureService;

        public VirtualMachinesController(IAzureService azureService)
        {
            _azureService = azureService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var vms = await _azureService.GetList();
                var result = vms.Select(vm => new VirtualMachine
                {
                    Id = vm.VMId,
                    Name = vm.ComputerName
                }).ToArray();

                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Failed to get virtual machines");
            }
        }
    }
}
