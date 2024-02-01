using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeaveParameterRepository : Repository<LeaveParameterMaster>
    {
        private AppDbContext _context;
        public LeaveParameterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeaveParameterMaster Update(LeaveParameterMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
