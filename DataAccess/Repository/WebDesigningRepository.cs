using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class WebDesigningRepository : Repository<WebDesignMaster>
    {
        private AppDbContext _context;
        public WebDesigningRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override WebDesignMaster Update(WebDesignMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
