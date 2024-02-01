using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class PunchDataRepository : Repository<PunchDataMaster>
    {
        private AppDbContext _context;
        public PunchDataRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override PunchDataMaster Update(PunchDataMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
