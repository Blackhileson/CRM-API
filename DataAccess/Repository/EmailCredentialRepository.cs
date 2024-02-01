using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class EmailCredentialRepository : Repository<EmailCredentialMaster>
    {
        private AppDbContext _context;
        public EmailCredentialRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override EmailCredentialMaster Update(EmailCredentialMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
