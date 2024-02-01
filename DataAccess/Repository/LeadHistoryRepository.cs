using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class LeadHistoryRepository : Repository<LeadHistoryMaster>
    {
        private AppDbContext _context;
        public LeadHistoryRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LeadHistoryMaster Update(LeadHistoryMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
