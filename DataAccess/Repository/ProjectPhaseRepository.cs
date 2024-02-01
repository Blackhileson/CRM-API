using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ProjectPhaseRepository : Repository<ProjectPhaseMaster>
    {
        private AppDbContext _context;
        public ProjectPhaseRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ProjectPhaseMaster Update(ProjectPhaseMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
