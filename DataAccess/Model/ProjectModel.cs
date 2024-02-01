using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
   public class ProjectModel
    {
        public string employeeId { get; set; }

        public decimal ProjectID { get; set; }
        
        public decimal? CompanyID { get; set; }
        
        public string CompanyName { get; set; }
        
        public decimal? ServiceGroupID { get; set; }
        
        public string ServiceGroupName { get; set; }
        
        public decimal? CustomerID { get; set; }
        
        public string CustomerName { get; set; }
        
        public decimal? ProjectLeaderId { get; set; }
        
        public string ProjectLeaderName { get; set; }
        
        public string ProjectName { get; set; }
        
        public DateTime? ExpectedStartDate { get; set; }
        
        public DateTime? ActualStartDate { get; set; }
        
        public DateTime? ExpectedEndDate { get; set; }
        
        public DateTime? ActualEndDate { get; set; }

        public string Langauge { get; set; }
        
        public decimal? TechnologyId { get; set; }
        
        public string TechnologyName { get; set; }
        
        public string Hardware { get; set; }

        public string Skill { get; set; }
        
        public string ProjectStatus { get; set; }
        
        public decimal? ProjectMangerID { get; set; }
        
        public string ProjectManagerName { get; set; }
        
        public string Description { get; set; }

        public bool? IsMultiPhase { get; set; }

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
