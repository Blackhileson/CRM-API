using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class MonthRepository : Repository<MonthMaster>
    {
        private AppDbContext _context;
        public MonthRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override MonthMaster Update(MonthMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
