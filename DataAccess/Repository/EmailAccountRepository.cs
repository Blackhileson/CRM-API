using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class EmailAccountRepository : Repository<EmailAccountMaster>
    {
        private AppDbContext _context;
        public EmailAccountRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override EmailAccountMaster Update(EmailAccountMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
