using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ShiftMasterRepository : Repository<ShiftMaster>
    {
        private AppDbContext _context;
        public ShiftMasterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ShiftMaster Update(ShiftMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
