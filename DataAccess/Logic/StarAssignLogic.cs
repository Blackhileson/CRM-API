using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class StarAssignLogic : StarAssignRepository
    {
        private AppDbContext _context;
        public StarAssignLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public StarAssignMaster GetAssignstarById(int Id)
        {
            return _context.StarAssignMasters.Where(x => x.IsActive == true && x.IsDisplay == true && x.StarAssignId == Id).OrderBy(x => x.StarAssignId).FirstOrDefault();

        }

        public List<StarAssignMaster> GetMyStarById(int Id)
        {
            List<StarAssignMaster> StarAssignMaster = Get().ToList().Where(s => s.IsActive == true && s.IsDisplay == true && s.GetEmployeeId == Id).OrderBy(x => x.StarAssignId).ToList();
            List<StarAssignMaster> StarAssignMasterList = new List<StarAssignMaster>();
            for (int i = 0; i < StarAssignMaster.Count; i++)
            {
                StarAssignMasterList.Add(new StarAssignMaster()
                {
                    StarAssignId = StarAssignMaster[i].StarAssignId,
                    StarName = StarAssignMaster[i].StarName,
                    GetEmployeeId = StarAssignMaster[i].GetEmployeeId,
                    GetEmployeeName = StarAssignMaster[i].GetEmployeeName,
                    AssignDate = StarAssignMaster[i].AssignDate,
                    GivenByEmployeeId = StarAssignMaster[i].GivenByEmployeeId
                 ,
                    Month = StarAssignMaster[i].Month,
                    GivenByEmployeeName = StarAssignMaster[i].GivenByEmployeeName,
                    Note = StarAssignMaster[i].Note,
                    IsDisplay = StarAssignMaster[i].IsDisplay,
                    IsActive = StarAssignMaster[i].IsActive
                });
            }
            return StarAssignMasterList;
        }

    }

}

