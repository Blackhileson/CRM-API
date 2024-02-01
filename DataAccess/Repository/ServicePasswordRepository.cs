using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ServicePasswordRepository : Repository<ServicePassword>
    {
        private AppDbContext _context;
        public ServicePasswordRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ServicePassword Update(ServicePassword obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
