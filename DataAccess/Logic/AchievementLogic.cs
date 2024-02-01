using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class AchievementLogic : AchievementRepository
    {
        private AppDbContext _context;
        public AchievementLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public AchievementMaster GetAchivementById(int Id)
        {
            return _context.AchievementMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.AchivementId == Id).OrderBy(x => x.AchivementId).FirstOrDefault();

        }
    }

}

