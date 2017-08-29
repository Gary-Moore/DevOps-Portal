using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DevOps.Portal.Application.SolutionCreation;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;
using DevOps.Portal.Web.Hubs;
using Microsoft.AspNet.SignalR;


namespace DevOps.Portal.Web.Controllers
{
    public class SolutionCreatorController : Controller
    {
        private readonly ICreateTeamcitySolutionCommand _command;

        public SolutionCreatorController(ICreateTeamcitySolutionCommand command)
        {
            _command = command;
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateSolutionModel model)
        {
            try
            {
                model.SourceControlUrl = "https://github.com/Gary-Moore/VetSurgery";
                var response = await _command.ExecuteAsync(model, NotifyProgress);                
                var returnData = new {result = response, success = true};

                return Json(returnData);
            }
            catch (TeamCityOperationException ex)
            {
                var returnData = new { result = "Failure", errors = ex.Errors.ToArray()};
                return Json(returnData);
            }
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