using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class ResponseBody
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public dynamic data { get; set; }
    }
}