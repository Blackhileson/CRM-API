using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class StarAssignRepository : Repository<StarAssignMaster>
    {
        private AppDbContext _context;
        public StarAssignRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override StarAssignMaster Update(StarAssignMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
