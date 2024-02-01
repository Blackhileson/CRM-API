using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageBankRepository : Repository<BankInfromationMaster>
    {
        private AppDbContext _context;
        public ManageBankRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override BankInfromationMaster Update(BankInfromationMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
