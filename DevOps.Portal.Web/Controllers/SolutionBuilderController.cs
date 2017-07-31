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

namespace DevOps.Portal.Web.Controllers
{
    public class SolutionBuilderController : Controller
    {
        private readonly ITeamcityService _teamcityService;

        public SolutionBuilderController(ITeamcityService teamcityService)
        {
            _teamcityService = teamcityService;
        }

        public async Task<ActionResult> Index()
        {
            var result = await _teamcityService.GetProjects();
            result = new List<Project>();
            return View(result);
        }

        public async Task<ActionResult> Create()
        {
            var result = await _teamcityService.CreateProject("Dave");
            return View(result);
        }
    }
}