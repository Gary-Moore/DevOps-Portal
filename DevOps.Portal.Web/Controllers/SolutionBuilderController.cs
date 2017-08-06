using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DevOps.Portal.Domain.Teamcity;
using DevOps.Portal.Infrastructure.Configuration;
using DevOps.Portal.Infrastructure.Network;
using DevOps.Portal.Infrastructure.Teamcity;
using DevOps.Portal.Web.Models.SolutionBuilder;
using DevOps.Portal.Application.Teamcity.Commands.CreateProject;
using DevOps.Portal.Application.Teamcity.Commands.CreateSolution;

namespace DevOps.Portal.Web.Controllers
{
    public class SolutionBuilderController : Controller
    {
        private readonly ITeamcityService _teamcityService;
        private readonly ICreateTeamcitySolutionCommand _command;

        public SolutionBuilderController(ITeamcityService teamcityService, ICreateTeamcitySolutionCommand command)
        {
            _teamcityService = teamcityService;
            _command = command;
        }

        public ActionResult Index()
        {
            var model = new CreateSolutionViewModel();
            return View(model);
        }

        public async Task<ActionResult> Create(CreateSolutionViewModel model)
        {
            await _command.Execute(model.SolutionName, model.SubProjectName, model.SourceControlUrl);
            return RedirectToAction("Index");
        }
        
    }
}