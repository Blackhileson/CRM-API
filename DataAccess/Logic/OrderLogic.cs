using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class OrderLogic : OrderRepository
    {
        private AppDbContext _context;
        public OrderLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

