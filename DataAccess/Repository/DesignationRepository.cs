using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class DesignationRepository : Repository<DesignationMaster>
    {
        private AppDbContext _context;
        public DesignationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override DesignationMaster Update(DesignationMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
