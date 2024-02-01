using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class CompanyMasterRepository : Repository<CompanyMaster>
    {
        private AppDbContext _context;
        public CompanyMasterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CompanyMaster Update(CompanyMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
