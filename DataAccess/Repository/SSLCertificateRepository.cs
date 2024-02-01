using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{

    public class SSLCertificateRepository : Repository<SSLCertificate>
    {
        private AppDbContext _context;
        public SSLCertificateRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override SSLCertificate Update(SSLCertificate obj)
        {
            // obj.UpdatedOn = ServerDate.Now();
            return base.Update(obj);
        }
    }

}
