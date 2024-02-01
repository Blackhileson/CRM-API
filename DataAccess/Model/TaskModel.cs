using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class TaskModel
    {

        public string employeeId { get; set; }
        public decimal TaskListID { get; set; }

        public string ProjectName { get; set; }
        
        public decimal? ProjectID { get; set; }
        
        public string ProjectPhaseName { get; set; }
        
        public decimal? ProjectPhaseID { get; set; }
        
        public string WorkListName { get; set; }
        
        public decimal? WorkListID { get; set; }

        public string WorkingDescriprion { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? ExceptedDate { get; set; }

        public TimeSpan? WorkingHours { get; set; }
        
        public decimal? Status { get; set; }

        public decimal? Employee { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public decimal? IsAddedBy { get; set; }
    }
}
