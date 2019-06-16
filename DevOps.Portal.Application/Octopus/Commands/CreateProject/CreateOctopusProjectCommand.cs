using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Octopus;
using Octopus.Client.Model;

namespace DevOps.Portal.Application.Octopus.Commands.CreateProject
{
    public class CreateOctopusProjectCommand : ICreateOctopusProjectCommand
    {
        private readonly IOctopusService _octopusService;

        public CreateOctopusProjectCommand(IOctopusService octopusService)
        {
            _octopusService = octopusService;
        }

        public async Task<ProjectResource> ExecuteAsync(ProjectResource project)
        {
            // factory to create project model

            // create project

            // set deployment step

            // set parameters

            return await _octopusService.CreateProjectAsync(project);
        }
    }
}
