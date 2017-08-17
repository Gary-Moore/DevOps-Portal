using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.Web.Models.SolutionBuilder;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;

namespace DevOps.Portal.Web.Controllers
{
    public class SolutionBuilderController : Controller
    {
        private readonly ICreateTeamcitySolutionCommand _command;

        public SolutionBuilderController(ICreateTeamcitySolutionCommand command)
        {
            _command = command;
        }

        public ActionResult Index()
        {
            var model = new CreateSolutionViewModel();
            return View(model);
        }

        public async Task<ActionResult> Create(CreateSolutionViewModel model)
        {
            try
            {
                await _command.Execute(model.SolutionName, model.SubProjectName, model.SourceControlUrl);
                return RedirectToAction("Index", "SolutionBuilder");
            }
            catch (TeamCityOperationException ex)
            {
                ViewBag.Error = ex.Errors.ToArray();
                return View("Index", model);
            }
            
        }
        
    }
}