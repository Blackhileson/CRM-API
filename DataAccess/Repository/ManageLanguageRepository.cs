using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ManageLanguageRepository : Repository<LanguageMaster>
    {
        private AppDbContext _context;
        public ManageLanguageRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override LanguageMaster Update(LanguageMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
