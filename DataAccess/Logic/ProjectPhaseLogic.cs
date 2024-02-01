using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ProjectPhaseLogic : ProjectPhaseRepository
    {
        private AppDbContext _context;
        public ProjectPhaseLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public ProjectPhaseMaster GetProjectphaseById(int Id)
        {
            return _context.ProjectPhaseMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.ProjectPhaseID == Id).OrderBy(x => x.ProjectPhaseID).FirstOrDefault();

        }
    }

}

