using System;
using System.Collections.Generic;

namespace DevOps.Portal.Infrastructure.Git
{
    public class GitLabOperationException : Exception
    {
        public GitLabOperationException(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public GitLabOperationException(IEnumerable<string> errors, string message) : base(message)
        {
            Errors = errors;
        }

        public GitLabOperationException(IEnumerable<string> errors, string message, Exception innerException) : base(message, innerException)
        {
            Errors = errors;
        }

        public IEnumerable<string> Errors { get; }
    }
}
