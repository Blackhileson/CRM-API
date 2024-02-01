using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class SEOSubmissionRepository : Repository<SEOSubmissionMaster>
    {
        private AppDbContext _context;
        public SEOSubmissionRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override SEOSubmissionMaster Update(SEOSubmissionMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
