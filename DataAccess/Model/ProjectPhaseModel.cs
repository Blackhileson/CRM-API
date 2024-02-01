using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class ProjectPhaseModel
    {
        public string employeeId { get; set; }
        public decimal ProjectPhaseID { get; set; }
        
        public decimal? ProjectID { get; set; }
        
        public string ProjectName { get; set; }
        
        public string PhaseName { get; set; }
        
        public DateTime? StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public string Hours { get; set; }

        public string Employee { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public string IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }
        
        public string IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }
        
        public string IsDeletedBy { get; set; }

    }
}
