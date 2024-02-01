using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class CityLogic : CityRepository
    {
        private AppDbContext _context;
        public CityLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public List<CityMaster> GetCityListByStateId(int StateId)
        {
            List<CityMaster> CityMaster = Get().ToList().Where(s => s.IsActive == true && s.IsDisplay == true && s.StateId == StateId).OrderBy(x => x.CountryId).ToList();
            List<CityMaster> CityMasterList = new List<CityMaster>();
            for (int i = 0; i < CityMaster.Count; i++)
            {
                CityMasterList.Add(new CityMaster() { CityId = CityMaster[i].CityId, CityName = CityMaster[i].CityName ,
                    CityShortName = CityMaster[i].CityShortName,
                    StateId = CityMaster[i].StateId,
                    StateName = CityMaster[i].StateName,
                    CountryName = CityMaster[i].CountryName,
                    CountryId = CityMaster[i].CountryId,
                    IsDisplay = CityMaster[i].IsDisplay,
                    IsActive = CityMaster[i].IsActive
                });
            }
            return CityMasterList;
        }



    }

}

