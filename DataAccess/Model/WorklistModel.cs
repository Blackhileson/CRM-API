using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class WorklistModel
    {
        public string employeeId { get; set; }

        public decimal WorklistID { get; set; }
        
        public decimal? ProjectID { get; set; }
        
        public string ProjectName { get; set; }

        public decimal? ProjectPhaseID { get; set; }
        
        public string PhaseName { get; set; }
        
        public string WorkName { get; set; }
        
        public string WorkDescription { get; set; }
        
        public string ProjectStatusID { get; set; }
        
        public string ProjectStatus { get; set; }
        
        public string WorkHour { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public decimal? IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }
        
        public decimal? IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }
        
        public decimal? IsDeletedBy { get; set; }

    }
}
