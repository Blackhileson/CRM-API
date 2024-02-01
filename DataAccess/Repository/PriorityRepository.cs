using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class PriorityRepository : Repository<PriorityMaster>
    {
        private AppDbContext _context;
        public PriorityRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override PriorityMaster Update(PriorityMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
