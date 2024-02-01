using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class EmailTemplateRepository : Repository<EmailTemplateMaster>
    {
        private AppDbContext _context;
        public EmailTemplateRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override EmailTemplateMaster Update(EmailTemplateMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
