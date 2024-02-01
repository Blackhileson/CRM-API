using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ManageBankLogic : ManageBankRepository
    {
        private AppDbContext _context;
        public ManageBankLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

