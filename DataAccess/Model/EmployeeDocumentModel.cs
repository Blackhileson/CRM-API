using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class EmployeeDocumentModel
    {
        public string employeeId { get; set; }

        public decimal EmployeeDocumentID { get; set; }
        
        public string EmployeeName { get; set; }
        
        public decimal? EmployeeID { get; set; }
        
        public string DocumentTypeID { get; set; }
        
        public string DocumentTypeName { get; set; }

        public string FileUpload { get; set; }

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
