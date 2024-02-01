using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class StatusRepository : Repository<StatusMaster>
    {
        private AppDbContext _context;
        public StatusRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override StatusMaster Update(StatusMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
