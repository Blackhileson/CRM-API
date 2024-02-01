using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logic
{

    public class StateLogic : StateRepository
    {
        private AppDbContext _context;
        public StateLogic(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

        public List<StateMaster> GetStateListByCountryId(int CountryId)
        {
            List<StateMaster> StateMaster = Get().ToList().Where(s => s.IsActive == true && s.IsDisplay == true && s.CountryId == CountryId).OrderBy(x => x.CountryId).ToList();
            List<StateMaster> StateMasterList = new List<StateMaster>();
            for (int i = 0; i < StateMaster.Count; i++)
            {
                StateMasterList.Add(new StateMaster() { StateId = StateMaster[i].StateId, StateName = StateMaster[i].StateName, StateShortCode = StateMaster[i].StateShortCode
                 , CountryName = StateMaster[i].CountryName,  CountryId = StateMaster[i].CountryId , IsDisplay = StateMaster[i].IsDisplay, IsActive = StateMaster[i].IsActive
                });
            }
            return StateMasterList;
        }





    }

}

