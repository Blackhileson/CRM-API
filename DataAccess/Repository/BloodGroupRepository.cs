using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class BloodGroupRepository : Repository<BloodGroupMaster>
    {
        private AppDbContext _context;
        public BloodGroupRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override BloodGroupMaster Update(BloodGroupMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
