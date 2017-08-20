using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;
using DevOps.Portal.Web.Models.SolutionCreator;

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
        public async Task<ActionResult> Create(CreateSolutionViewModel model)
        {
            try
            {
                model.SourceControlUrl = "https://github.com/Gary-Moore/VetSurgery";
                await _command.Execute(model.TeamCityNewParentProjectName, model.TeamCitySubprojectName,
                    model.SourceControlUrl, model.VisualStudioSolutionName);
                var returnData = new {result = "Success"};

                return Json(returnData);
            }
            catch (TeamCityOperationException ex)
            {
                var returnData = new { result = "Failure", errors = ex.Errors.ToArray()};
                return Json(returnData);
            }
        }
    }
}