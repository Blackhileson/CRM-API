﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class WebHostingRepository : Repository<WebHosting>
    {
        private AppDbContext _context;
        public WebHostingRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override WebHosting Update(WebHosting obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}