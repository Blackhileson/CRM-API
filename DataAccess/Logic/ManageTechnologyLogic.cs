using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ManageTechnologyLogic : ManageTechnologyRepository
    {
        private AppDbContext _context;
        public ManageTechnologyLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

