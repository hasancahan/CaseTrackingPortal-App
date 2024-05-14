using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupCaseResultLManager : ILookupCaseResultLService
    {

        private ILookupCaseResultLRepository _lookupCaseResultLRepository ;
        public LookupCaseResultLManager(ILookupCaseResultLRepository lookupCaseResultLRepository)
        {
            _lookupCaseResultLRepository = lookupCaseResultLRepository;
        }


        public void Add(LookupCaseResultL lookupCaseResultL)
        {
            _lookupCaseResultLRepository.Add(lookupCaseResultL);
        }

        public void Delete(int CaseResultId)
        {
            _lookupCaseResultLRepository.Delete(new LookupCaseResultL { CaseResultId = CaseResultId });
        }

        public List<LookupCaseResultL> GetAll()
        {
            return _lookupCaseResultLRepository.GetList();
        }

        public void Update(LookupCaseResultL lookupCaseResultL)
        {
            _lookupCaseResultLRepository.Update(lookupCaseResultL);
        }
    }
}
