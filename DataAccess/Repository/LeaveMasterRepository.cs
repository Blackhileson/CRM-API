using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeaveMasterRepository : Repository<LeaveMaster>
    {
        private AppDbContext _context;
        public LeaveMasterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeaveMaster Update(LeaveMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
