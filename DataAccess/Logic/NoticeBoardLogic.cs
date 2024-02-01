using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class NoticeBoardLogic : NoticeBoardRepository
    {
        private AppDbContext _context;
        public NoticeBoardLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }



        public NoticeBoardMaster GetNoticeById(int Id)
        {
            return _context.NoticeBoardMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.NoticeBoardId == Id).OrderBy(x => x.NoticeBoardId).FirstOrDefault();

        }

    }

}

