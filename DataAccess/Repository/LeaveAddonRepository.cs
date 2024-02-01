using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeaveAddonRepository : Repository<LeaveAddonMaster>
    {
        private AppDbContext _context;
        public LeaveAddonRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeaveAddonMaster Update(LeaveAddonMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
