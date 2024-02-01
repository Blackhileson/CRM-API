﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class StateRepository : Repository<StateMaster>
    {
        private AppDbContext _context;
        public StateRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override StateMaster Update(StateMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}