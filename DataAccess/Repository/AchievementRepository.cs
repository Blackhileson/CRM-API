using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class AchievementRepository : Repository<AchievementMaster>
    {
        private AppDbContext _context;
        public AchievementRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override AchievementMaster Update(AchievementMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
