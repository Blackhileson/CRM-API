using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ServiceGroupLogic : ServiceGroupRepository
    {
        private AppDbContext _context;
        public ServiceGroupLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

