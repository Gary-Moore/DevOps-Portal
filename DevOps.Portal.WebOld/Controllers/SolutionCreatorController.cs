using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Application.SolutionCreation.Commands;
using DevOps.Portal.Application.SolutionCreation.Validation;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.Web.Controllers;
using DevOps.Portal.Web.Hubs;
using DevOps.Portal.Web.Models;
using Microsoft.AspNet.SignalR;

namespace DevOps.Portal.WebOld.Controllers
{
    public class SolutionCreatorController : BaseController
    {
        private readonly ICreateSolutionCommand _command;
        private readonly IValidationEngine _validationEngine;

        public SolutionCreatorController(ICreateSolutionCommand command, IValidationEngine validationEngine)
        {
            _command = command;
            _validationEngine = validationEngine;
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateSolutionModel model)
        {
            var response = new WebResponse();
            try
            {
                model.SourceControlUrl = "https://github.com/Gary-Moore/VetSurgery";
                model.TemplateUrl = Server.MapPath("~/Templates/Solution.zip");
                var validationResponse = _validationEngine.Eval(model);
                if (!validationResponse.Success)
                {
                    response = new WebResponse()
                    {
                        ErrorMessages = validationResponse.Errors,
                        Successful = validationResponse.Success
                    };
                }
                else
                {
                    var actionResponse = await _command.ExecuteAsync(model, NotifyProgress);
                    response = new WebResponse<CreateSolutionResponse>()
                    {
                        Data = actionResponse,
                        Successful = true
                    };
                }
                
            }
            catch (TeamCityOperationException ex)
            {
                response.ErrorMessages = ex.Errors.ToArray();
                response.Successful = false;
            }

            return Json(response);
        }
        
        public void NotifyProgress(CreateSolutionModel model, string message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<SolutionCreationHub>();
            if (hubContext != null)
            {
                var data = new {model, currentStatus = message};
                hubContext.Clients.Client(model.ConnectionId).progress(data);
            }
        }
    }
}