using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class LeaveMasterLogic : LeaveMasterRepository
    {
        private AppDbContext _context;
        public LeaveMasterLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

