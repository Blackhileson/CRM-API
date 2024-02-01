using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageEmployeeDocRepository : Repository<ManageEmployeeDocumentMaster>
    {
        private AppDbContext _context;
        public ManageEmployeeDocRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ManageEmployeeDocumentMaster Update(ManageEmployeeDocumentMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
