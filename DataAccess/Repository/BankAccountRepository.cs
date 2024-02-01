using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class BankAccountRepository : Repository<BankACTypeMaster>
    {
        private AppDbContext _context;
        public BankAccountRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override BankACTypeMaster Update(BankACTypeMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
