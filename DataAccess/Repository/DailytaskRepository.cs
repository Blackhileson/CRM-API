using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class DailytaskRepository : Repository<DailytaskMaster>
    {
        private AppDbContext _context;
        public DailytaskRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override DailytaskMaster Update(DailytaskMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}

