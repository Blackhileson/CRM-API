using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class GenderRepository : Repository<GenderMaster>
    {
        private AppDbContext _context;
        public GenderRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override GenderMaster Update(GenderMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
