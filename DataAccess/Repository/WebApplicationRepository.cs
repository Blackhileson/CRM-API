using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class WebApplicationRepository : Repository<WebApplicationMaster>
    {
        private AppDbContext _context;
        public WebApplicationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override WebApplicationMaster Update(WebApplicationMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
