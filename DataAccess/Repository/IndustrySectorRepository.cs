using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class IndustrySectorRepository : Repository<IndustrySectorMaster>
    {
        private AppDbContext _context;
        public IndustrySectorRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override IndustrySectorMaster Update(IndustrySectorMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
