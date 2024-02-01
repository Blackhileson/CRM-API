﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class CountryRepository : Repository<CountryMaster>
    {
        private AppDbContext _context;
        public CountryRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CountryMaster Update(CountryMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
