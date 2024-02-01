using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class MobileApplicationRepository : Repository<MobileApplication>
    {
        private AppDbContext _context;
        public MobileApplicationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override MobileApplication Update(MobileApplication obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
