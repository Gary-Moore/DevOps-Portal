using System.Collections.Generic;

namespace DevOps.Portal.Application
{
    public class ActionResponse
    {
        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }

    public class ActionResponse<T> : ActionResponse
    {
        public T Data { get; set; }
    }
}
