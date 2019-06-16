using System.Linq;
using DevOps.Portal.Application.SolutionCreation.Validation.Rules;

namespace DevOps.Portal.Application.SolutionCreation.Validation
{
    public class ValidationEngine : IValidationEngine
    {
        public ActionResponse Eval(CreateSolutionModel model)
        {
            var teamcityResults = new TeamCityValidationRules().Validate(model);

            var response = new ActionResponse(){Success = true};

            if (teamcityResults.Any(res => !res.IsValid))
            {
                response.Success = false;
                response.Errors = teamcityResults.Select(res => res.Message);
            }

            return response;
        }
    }
}
