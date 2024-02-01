using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class CampaignRepository : Repository<CampaignMaster>
    {
        private AppDbContext _context;
        public CampaignRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CampaignMaster Update(CampaignMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
