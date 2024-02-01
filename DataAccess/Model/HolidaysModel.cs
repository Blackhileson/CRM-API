using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class HolidaysModel
    {

        public string employeeId { get; set; }

        public decimal HolidayId { get; set; }

        public string HolidayName { get; set; }
        
        public decimal? LeaveParameterId { get; set; }
        
        public string LeaveParameterName { get; set; }

        public DateTime? HolidayDate { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? IsAddedOn { get; set; }
        
        public decimal? IsAddedBy { get; set; }

        public DateTime? IsUpdatedOn { get; set; }
        
        public decimal? IsUpdatedBy { get; set; }

        public DateTime? IsDeletedOn { get; set; }
        
        public decimal? IsDeletedBy { get; set; }
        
        public string LeaveParameter { get; set; }

    }
}
