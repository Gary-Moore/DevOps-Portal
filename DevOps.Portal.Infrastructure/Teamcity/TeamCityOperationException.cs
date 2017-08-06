using System;
using System.Collections;
using System.Collections.Generic;

namespace DevOps.Portal.Infrastructure.Teamcity
{
    public class TeamCityOperationException : Exception
    {
        public TeamCityOperationException(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public TeamCityOperationException(IEnumerable<string> errors, string message):base(message)
        {
            Errors = errors;
        }

        public TeamCityOperationException(IEnumerable<string> errors, string message, Exception innerException):base(message, innerException)
        {
            Errors = errors;
        }

        public IEnumerable<string> Errors { get; }
    }
}
