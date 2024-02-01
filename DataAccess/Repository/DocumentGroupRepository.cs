using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class DocumentGroupRepository : Repository<CompanyDocumentTypeMaster>
    {
        private AppDbContext _context;
        public DocumentGroupRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override CompanyDocumentTypeMaster Update(CompanyDocumentTypeMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
