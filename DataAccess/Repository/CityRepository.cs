using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class CityRepository : Repository<CityMaster>
    {
        private AppDbContext _context;
        public CityRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CityMaster Update(CityMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
