using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class TaskDayRepository : Repository<TaskListMaster>
    {
        private AppDbContext _context;
        public TaskDayRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override TaskListMaster Update(TaskListMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
