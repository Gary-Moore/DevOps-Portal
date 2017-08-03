using System.Collections.Generic;
using System.Linq;

namespace DevOps.Portal.Infrastructure.Network
{
    public class NetworkResponse<T>
    {
        public NetworkResponse(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public NetworkResponse(T responseData)
        {
            ResponseData = responseData;
        }

        public bool Success => Errors.Any();

        public IEnumerable<string> Errors { get; }

        public T ResponseData { get; }
    }
}
