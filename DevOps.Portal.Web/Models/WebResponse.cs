using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOps.Portal.Web.Models
{
    public class WebResponse
    {
        public WebResponse()
        {
            
        }

        public bool Successful { get; set; }

        public IEnumerable<string> ErrorMessages { get; set; } = new List<string>();
    }

    public class WebResponse<T> : WebResponse
    {
        public T Data { get; set; }
    }
}