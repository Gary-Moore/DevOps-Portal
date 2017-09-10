using System.Collections.Generic;

namespace DevOps.Portal.Application.SolutionCreation.Validation
{
    public interface IValidationEngine
    {
        ActionResponse Eval(CreateSolutionModel model);
    }
}