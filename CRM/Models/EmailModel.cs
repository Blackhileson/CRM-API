using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string FromMailer { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }
        public decimal FormID { get; set; }
    }
}
