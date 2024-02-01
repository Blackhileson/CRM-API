using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeadMasterRepository : Repository<LeadMaster>
    {
        private AppDbContext _context;
        public LeadMasterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeadMaster Update(LeadMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
