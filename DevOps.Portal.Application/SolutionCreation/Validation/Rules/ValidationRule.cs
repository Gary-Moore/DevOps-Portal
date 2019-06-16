using System;
using System.Linq.Expressions;

namespace DevOps.Portal.Application.SolutionCreation.Validation.Rules
{
    public class ValidationRule<T> where T : class 
    {
        public ValidationRule(Expression<Func<T, bool>> ruleExpression)
        {
            RuleExpression = ruleExpression;
        }

        public string Message { get; set; }
        public bool IsValid { get; set; }
        public Expression<Func<T, bool>> RuleExpression { get; internal set; }
    }
}
