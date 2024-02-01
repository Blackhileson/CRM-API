using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ProjectMeetingRepository : Repository<ProjectMeetingMaster>
    {
        private AppDbContext _context;
        public ProjectMeetingRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ProjectMeetingMaster Update(ProjectMeetingMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
