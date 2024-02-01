using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ServicePasswordLogic : ServicePasswordRepository
    {
        private AppDbContext _context;
        public ServicePasswordLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}
