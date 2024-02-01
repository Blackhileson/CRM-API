using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class StarModel
    {
        public string employeeId { get; set; }

        public decimal StarId { get; set; }
        
        public string Starname { get; set; }
        
        public string Image { get; set; }

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
