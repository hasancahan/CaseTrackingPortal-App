using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupCaseSubjectLManager : ILookupCaseSubjectLService
    {
        private ILookupCaseSubjectLRepository _lookupCaseSubjectLRepository;
        public LookupCaseSubjectLManager(ILookupCaseSubjectLRepository lookupCaseSubjectLRepository)
        {
            _lookupCaseSubjectLRepository = lookupCaseSubjectLRepository;
        }

        public void Add(LookupCaseSubjectL lookupCaseSubjectL)
        {
            _lookupCaseSubjectLRepository.Add(lookupCaseSubjectL);
        }

        public void Delete(int CaseSubjectId)
        {
            _lookupCaseSubjectLRepository.Delete(new LookupCaseSubjectL { CaseSubjectId = CaseSubjectId });
        }

        public List<LookupCaseSubjectL> GetAll()
        {
            return _lookupCaseSubjectLRepository.GetList();
        }

        public void Update(LookupCaseSubjectL lookupCaseSubjectL)
        {
            _lookupCaseSubjectLRepository.Update(lookupCaseSubjectL);
        }
    }
}
