using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class SMMSubmissionRepository : Repository<SMMSubmission>
    {
        private AppDbContext _context;
        public SMMSubmissionRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override SMMSubmission Update(SMMSubmission obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
