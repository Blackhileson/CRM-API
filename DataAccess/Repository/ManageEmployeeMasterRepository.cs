using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageEmployeeMasterRepository : Repository<EmployeeMaster>
    {
        private AppDbContext _context;
        public ManageEmployeeMasterRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override EmployeeMaster Update(EmployeeMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
