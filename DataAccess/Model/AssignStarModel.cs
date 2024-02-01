using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class AssignStarModel
    {
        public string employeeId { get; set; }

        public decimal StarAssignId { get; set; }
        
        public decimal? GetEmployeeId { get; set; }
        
        public string GetEmployeeName { get; set; }
        
        public DateTime? AssignDate { get; set; }
        
        public string Month { get; set; }
        
        public decimal? StarId { get; set; }
        
        public string StarName { get; set; }

        public string StarImgURL { get; set; }
        
        public decimal? GivenByEmployeeId { get; set; }
        
        public string GivenByEmployeeName { get; set; }

        public string Note { get; set; }

        public bool? IsDisplay { get; set; }

        public bool? IsActive { get; set; }

    }
}
