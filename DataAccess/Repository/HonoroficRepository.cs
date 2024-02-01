using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class HonoroficRepository : Repository<HonorificMaster>
    {
        private AppDbContext _context;
        public HonoroficRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override HonorificMaster Update(HonorificMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
