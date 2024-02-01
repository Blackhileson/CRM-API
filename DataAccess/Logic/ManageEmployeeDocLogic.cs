using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ManageEmployeeDocLogic : ManageEmployeeDocRepository
    {
        private AppDbContext _context;
        public ManageEmployeeDocLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }



        public ManageEmployeeDocumentMaster GetEmpDocById(int Id)
        {
            return _context.ManageEmployeeDocumentMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.EmployeeDocumentID == Id).OrderBy(x => x.EmployeeDocumentID).FirstOrDefault();

        }

    }

}

