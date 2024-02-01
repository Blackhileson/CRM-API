using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class ManageEmployeeMasterLogic : ManageEmployeeMasterRepository
    {
        private AppDbContext _context;
        public ManageEmployeeMasterLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }


        public EmployeeMaster GetPassword(decimal EmployeeId, string Password)
        {
            return _context.EmployeeMasters.Where(b => b.IsActive == true && b.IsDisplay == true && b.EmployeeID == EmployeeId && b.Password == Password).FirstOrDefault();
        }

        public EmployeeMaster GetEmployeeById(int EmployeeId)
        {
            return _context.EmployeeMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.EmployeeID == EmployeeId).OrderBy(x => x.EmployeeID).FirstOrDefault();

        }
        public bool CheckExist(string Username)
        {


            if ((_context.EmployeeMasters.Where(u => u.Username == Username && u.IsActive == true).FirstOrDefault()) == null)
            {
                return false;
            }
            return true;
        }

        public EmployeeMaster Forgotpassword(string Username)
        {

            EmployeeMaster ManageEmployeeMaster = _context.EmployeeMasters.Where(u => u.Username == Username && u.IsActive == true).FirstOrDefault();
            if (ManageEmployeeMaster != null)
            {
                //   MailToClient(EmployeeMaster.Email, EmployeeMaster.bra, EmployeeMaster.Password);
            }

            return ManageEmployeeMaster;


        }

    }

}

