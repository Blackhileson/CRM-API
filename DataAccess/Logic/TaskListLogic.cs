using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class TaskListLogic : TaskDayRepository
    {
        private AppDbContext _context;
        public TaskListLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public TaskListMaster GetTaskById(int Id)
        {
            return _context.TaskListMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.TaskListID == Id).OrderBy(x => x.TaskListID).FirstOrDefault();

        }

    }

}

