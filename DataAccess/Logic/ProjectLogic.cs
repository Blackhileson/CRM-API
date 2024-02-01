using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ProjectLogic : ProjectRepository
    {
        private AppDbContext _context;
        public ProjectLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public ProjectMaster GetProjectById(int Id)
        {
            return _context.ProjectMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.ProjectID == Id).OrderBy(x => x.ProjectID).FirstOrDefault();

        }
    }

}

