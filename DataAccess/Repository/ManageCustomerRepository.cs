using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageCustomerRepository : Repository<CustomerMaster>
    {
        private AppDbContext _context;
        public ManageCustomerRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CustomerMaster Update(CustomerMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
