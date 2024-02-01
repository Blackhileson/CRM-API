using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
   public class AchievementModel
    {
        public string employeeId { get; set; }

        public decimal AchivementId { get; set; }
        
        public decimal? GetEmployeeId { get; set; }
        
        public string GetEmployeeName { get; set; }
        
        public string ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ReasonOfAppreciation { get; set; }

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
