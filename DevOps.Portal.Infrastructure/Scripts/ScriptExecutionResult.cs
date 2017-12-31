using System.Collections.Generic;

namespace DevOps.Portal.Infrastructure.Scripts
{
    public class ScriptExecutionResult
    {
        public ScriptExecutionResult()
        {
            Messages = new List<string>();
            ErrorMessages = new List<string>();
            Outputs = new List<object>();
        }

        public bool Suceess { get; set; }

        public IList<string> Messages { get; }
        public IList<string> ErrorMessages { get; }
        public IList<object> Outputs { get; }

        public static implicit operator bool(ScriptExecutionResult result)
        {
            return result.Suceess;
        }
    }
}
