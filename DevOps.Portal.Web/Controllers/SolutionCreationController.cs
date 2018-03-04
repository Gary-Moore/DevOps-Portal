using System;
using System.Collections.Generic;
using System.Web.Http;
using DevOps.Portal.Web.Models.SolutionCreator;

namespace DevOps.Portal.Web.Controllers
{
    [Route("api/solution-creation")]
    public class SolutionCreationController : ApiController
    {
        public SolutionCreationController()
        {
            
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]VisualStudioProjectViewModel model)
        {
            Console.Write("post" + model.ProjectName);
        }
    }
}