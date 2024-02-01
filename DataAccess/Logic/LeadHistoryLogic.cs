using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class LeadHistoryLogic : LeadHistoryRepository
    {
        private AppDbContext _context;
        public LeadHistoryLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

