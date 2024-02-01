using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class ApprovalModel
    {
        public string QmsId { get; set; }
        public string Remark { get; set; }
        public string FilePath { get; set; }
        public string RootCause { get; set; }
        public string CorrectiveAction { get; set; }
        public DateTime CTargetDate { get; set; }
        public string CResponsibility { get; set; }
        public string PreventiveAction { get; set; }
        public DateTime PTargetDate { get; set; }
        public string PResponsibility { get; set; }
        public string EmployeeID { get; set; }
        public string QMSNumber { get; set; }
    }
}