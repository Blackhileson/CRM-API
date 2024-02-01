using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class MonthLogic : MonthRepository
    {
        private AppDbContext _context;
        public MonthLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public WorklistMaster GetworklistById(int Id)
        {
            return _context.WorklistMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.WorklistID == Id).OrderBy(x => x.WorklistID).FirstOrDefault();

        }

    }

}

