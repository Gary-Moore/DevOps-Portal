using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
