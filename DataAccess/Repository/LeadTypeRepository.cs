using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeadTypeRepository : Repository<LeadTypeMaster>
    {
        private AppDbContext _context;
        public LeadTypeRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeadTypeMaster Update(LeadTypeMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
