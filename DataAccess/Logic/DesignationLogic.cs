﻿using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class DesignationLogic : DesignationRepository
    {
        private AppDbContext _context;
        public DesignationLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }

}

