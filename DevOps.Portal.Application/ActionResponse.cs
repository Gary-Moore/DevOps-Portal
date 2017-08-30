using System.Collections.Generic;

namespace DevOps.Portal.Application
{
    public class ActionResponse
    {
        public bool Success { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
