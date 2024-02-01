using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class StarLogic : StarRepository
    {
        private AppDbContext _context;
        public StarLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public StarMaster GetStarById(int Id)
        {
            return _context.StarMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.StarId == Id).OrderBy(x => x.StarId).FirstOrDefault();

        }

    }

}

