using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class TaskRequestModel
    {
        public string employeeId { get; set; }

        public decimal DailyTaskID { get; set; }
        
        public decimal TaskListID { get; set; }

        public string ProjectName { get; set; }
        
        public decimal? ProjectID { get; set; }
        
        public string ProjectPhaseName { get; set; }
        
        public decimal? ProjectPhaseID { get; set; }
        
        public string WorkListName { get; set; }
        
        public decimal? WorkListID { get; set; }

        public TimeSpan? TodayWorkingHours { get; set; }
        
        public string Priority { get; set; }
        
        public decimal? EmployeeId { get; set; }

        public bool? IsApprove { get; set; }
        
        public DateTime? Date { get; set; }

        public string RejectRemark { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public decimal? IsAddedBy { get; set; }

    }
}
