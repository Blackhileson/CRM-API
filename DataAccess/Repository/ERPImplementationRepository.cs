using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ERPImplementationRepository : Repository<ERPImplemetationMaster>
    {
        private AppDbContext _context;
        public ERPImplementationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ERPImplemetationMaster Update(ERPImplemetationMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
