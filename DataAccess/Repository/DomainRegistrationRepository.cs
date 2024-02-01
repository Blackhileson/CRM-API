using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class DomainRegistrationRepository : Repository<DomainRegistrationMaster>
    {
        private AppDbContext _context;
        public DomainRegistrationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override DomainRegistrationMaster Update(DomainRegistrationMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
