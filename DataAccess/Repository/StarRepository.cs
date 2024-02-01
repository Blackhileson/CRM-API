using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class StarRepository : Repository<StarMaster>
    {
        private AppDbContext _context;
        public StarRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override StarMaster Update(StarMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
