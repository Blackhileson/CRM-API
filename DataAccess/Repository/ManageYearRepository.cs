using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageYearRepository : Repository<YearMaster>
    {
        private AppDbContext _context;
        public ManageYearRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override YearMaster Update(YearMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
