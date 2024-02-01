using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ManageYearLogic : ManageYearRepository
    {
        private AppDbContext _context;
        public ManageYearLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

