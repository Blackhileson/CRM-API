using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class CustomerLogic : CustomerRepository
    {
        private AppDbContext _context;
        public CustomerLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

