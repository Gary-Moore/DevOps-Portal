using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Portal.Application.SolutionCreation.Validation.Rules
{
    public class TeamCityValidationRules
    {
        public IList<ValidationRule<CreateSolutionModel>> ValidationRules { get; set; }
        public IList<ValidationResult> ValidationResults { get; set; } = new List<ValidationResult>();

        public TeamCityValidationRules()
        {
            ValidationRules = new List<ValidationRule<CreateSolutionModel>>
            {
                new ValidationRule<CreateSolutionModel>(
                    model => !string.IsNullOrWhiteSpace(model.TeamCityNewParentProjectName))
            };
        }

        public IList<ValidationResult> Validate(CreateSolutionModel model)
        {
            foreach (var rule in ValidationRules)
            {
                var isValid = rule.RuleExpression.Compile()(model);

                var result = new ValidationResult(){IsValid = isValid, Message = rule.Message};
                ValidationResults.Add(result);
            }

            return ValidationResults;
        }
    }
}
