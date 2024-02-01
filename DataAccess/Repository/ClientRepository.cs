using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class ClientRepository : Repository<ClientMaster>
    {
        private AppDbContext _context;
        public ClientRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override ClientMaster Update(ClientMaster obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
