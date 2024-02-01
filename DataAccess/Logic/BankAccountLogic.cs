using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class BankAccountLogic : BankAccountRepository
    {
        private AppDbContext _context;
        public BankAccountLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

