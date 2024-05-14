using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;

namespace DavaSurecTakip.Business.Concrete
{
    public class CaseManager : ICaseService
    {
        private ICaseRepository _caseRepository;
        public CaseManager(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }
        public void Add(Case @case)
        {
            _caseRepository.Add(@case);
        }

        public void Delete(int CaseId)
        {
            _caseRepository.Delete(new Case { CaseId = CaseId });
        }

       
        public List<Case> GetAll()
        {
            return _caseRepository.GetList();
        }

        public Case GetById(int CaseId)
        {
            return _caseRepository.Get(p => p.CaseId == CaseId);
        }

        public void Update(Case @case)
        {
            _caseRepository.Update(@case);
        }
    }
}
