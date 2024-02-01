using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class HolidaysLogic : HolidaysRepository
    {
        private AppDbContext _context;
        public HolidaysLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public HolidayMaster GetHolidayById(int Id)
        {
            return _context.HolidayMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.HolidayId == Id).OrderBy(x => x.HolidayId).FirstOrDefault();

        }

    }

}

