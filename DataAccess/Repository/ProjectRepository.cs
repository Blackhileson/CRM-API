using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ProjectRepository : Repository<ProjectMaster>
    {
        private AppDbContext _context;
        public ProjectRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ProjectMaster Update(ProjectMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
