using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ServiceGroupRepository : Repository<ServiceGroupMaster>
    {
        private AppDbContext _context;
        public ServiceGroupRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ServiceGroupMaster Update(ServiceGroupMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
