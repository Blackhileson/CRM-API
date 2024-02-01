using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class OrderRepository : Repository<OrderMaster>
    {
        private AppDbContext _context;
        public OrderRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override OrderMaster Update(OrderMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
