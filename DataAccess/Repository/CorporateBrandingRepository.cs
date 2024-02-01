using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class CorporateBrandingRepository : Repository<CorporateBrandingMaster>
    {
        private AppDbContext _context;
        public CorporateBrandingRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CorporateBrandingMaster Update(CorporateBrandingMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
