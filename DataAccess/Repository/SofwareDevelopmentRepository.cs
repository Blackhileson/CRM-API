using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class SofwareDevelopmentRepository : Repository<SoftwareDevelopmentMaster>
    {
        private AppDbContext _context;
        public SofwareDevelopmentRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override SoftwareDevelopmentMaster Update(SoftwareDevelopmentMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
