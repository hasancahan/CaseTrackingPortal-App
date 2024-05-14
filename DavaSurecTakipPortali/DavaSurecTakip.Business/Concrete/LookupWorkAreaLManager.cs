using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupWorkAreaLManager : ILookupWorkAreaLService
    {

        private ILookupWorkAreaLRepository _lookupWorkAreaLRepository;
        public LookupWorkAreaLManager(ILookupWorkAreaLRepository lookupWorkAreaLRepository)
        {
            _lookupWorkAreaLRepository = lookupWorkAreaLRepository;
        }

        public void Add(LookupWorkAreaL lookupWorkAreaL)
        {
            _lookupWorkAreaLRepository.Add(lookupWorkAreaL);
        }

        public void Delete(int WorkAreaId)
        {
            _lookupWorkAreaLRepository.Delete(new LookupWorkAreaL { WorkAreaId = WorkAreaId });

        }

        public List<LookupWorkAreaL> GetAll()
        {
            return _lookupWorkAreaLRepository.GetList();
        }

        public void Update(LookupWorkAreaL lookupWorkAreaL)
        {
            _lookupWorkAreaLRepository.Update(lookupWorkAreaL);
        }
    }
}
