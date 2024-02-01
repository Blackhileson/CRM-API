using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageSkillRepository : Repository<EmployeeSkillMaster>
    {
        private AppDbContext _context;
        public ManageSkillRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override EmployeeSkillMaster Update(EmployeeSkillMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
