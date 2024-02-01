using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class DepartmentRepository : Repository<DepartmentMaster>
    {
        private AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override DepartmentMaster Update(DepartmentMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
