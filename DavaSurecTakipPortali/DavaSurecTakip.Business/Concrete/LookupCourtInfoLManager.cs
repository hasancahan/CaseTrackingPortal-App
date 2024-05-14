using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupCourtInfoLManager : ILookupCourtInfoLService
    {

        private ILookupCourtInfoLRepository _lookupCourtInfoLRepository;
        public LookupCourtInfoLManager(ILookupCourtInfoLRepository lookupCourtInfoLRepository)
        {
            _lookupCourtInfoLRepository = lookupCourtInfoLRepository;
        }

        public void Add(LookupCourtInfoL lookupCourtInfoL)
        {
            _lookupCourtInfoLRepository.Add(lookupCourtInfoL);
        }

        public void Delete(int CourtinInfoId)
        {
            _lookupCourtInfoLRepository.Delete(new LookupCourtInfoL { CourtinInfoId = CourtinInfoId });
        }

        public List<LookupCourtInfoL> GetAll()
        {
            return _lookupCourtInfoLRepository.GetList();
        }

        public void Update(LookupCourtInfoL lookupCourtInfoL)
        {
            _lookupCourtInfoLRepository.Update(lookupCourtInfoL);
        }
    }
}
