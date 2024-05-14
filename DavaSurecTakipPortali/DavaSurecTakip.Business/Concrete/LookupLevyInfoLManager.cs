using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupLevyInfoLManager : ILookupLevyInfoLService
    {

        private ILookupLevyInfoLRepository _lookupLevyInfoLRepository;
        public LookupLevyInfoLManager(ILookupLevyInfoLRepository lookupLevyInfoLRepository)
        {
            _lookupLevyInfoLRepository = lookupLevyInfoLRepository;
        }
        public void Add(LookupLevyInfoL lookupLevyInfoL)
        {
            _lookupLevyInfoLRepository.Add(lookupLevyInfoL);
        }

        public void Delete(int LevyInfoId)
        {
            _lookupLevyInfoLRepository.Delete(new LookupLevyInfoL { LevyInfoId = LevyInfoId });

        }

        public List<LookupLevyInfoL> GetAll()
        {
            return _lookupLevyInfoLRepository.GetList();
        }

        public void Update(LookupLevyInfoL lookupLevyInfoL)
        {
            _lookupLevyInfoLRepository.Update(lookupLevyInfoL);
        }
    }
}
