using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class WorklistRepository : Repository<WorklistMaster>
    {
        private AppDbContext _context;
        public WorklistRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override WorklistMaster Update(WorklistMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
