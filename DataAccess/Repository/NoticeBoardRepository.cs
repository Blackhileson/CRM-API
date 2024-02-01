using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class NoticeBoardRepository : Repository<NoticeBoardMaster>
    {
        private AppDbContext _context;
        public NoticeBoardRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override NoticeBoardMaster Update(NoticeBoardMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
