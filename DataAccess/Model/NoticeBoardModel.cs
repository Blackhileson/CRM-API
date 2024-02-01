using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class NoticeBoardModel
    {

        public string employeeId { get; set; }

        public decimal NoticeBoardId { get; set; }

        public string NoticeTitle { get; set; }

        public DateTime? NoticeDate { get; set; }

        public string DocumentUrl { get; set; }
        
        public decimal? EmployeeName { get; set; }

        public string Description { get; set; }

        public bool? IsToAllEmployee { get; set; }

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
