using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupAttornerLManager : ILookupAttornerLService
    {

        private ILookupAttornerLRepository _lookupAttornerLRepository;
        public LookupAttornerLManager(ILookupAttornerLRepository lookupAttornerLRepository)
        {
            _lookupAttornerLRepository = lookupAttornerLRepository;
        }
        public void Add(LookupAttornerL lookupAttornerL)
        {
            _lookupAttornerLRepository.Add(lookupAttornerL);
        }

        public void Delete(int AttornerId)
        {
            _lookupAttornerLRepository.Delete(new LookupAttornerL { AttornerId = AttornerId });
        }

        public List<LookupAttornerL> GetAll()
        {
            return _lookupAttornerLRepository.GetList();
        }

        public LookupAttornerL GetById(int AttornerId)
        {
            return _lookupAttornerLRepository.Get(p => p.AttornerId == AttornerId);
        }

        public void Update(LookupAttornerL lookupAttornerL)
        {
            _lookupAttornerLRepository.Update(lookupAttornerL);
        }
    }
}
