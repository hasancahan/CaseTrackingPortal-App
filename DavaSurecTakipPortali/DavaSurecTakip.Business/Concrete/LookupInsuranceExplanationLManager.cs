using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupInsuranceExplanationLManager : ILookupInsuranceExplanationLService
    {
        private ILookupInsuranceExplanationLRepository _lookupInsuranceExplanationLRepository1;
        public LookupInsuranceExplanationLManager(ILookupInsuranceExplanationLRepository lookupInsuranceExplanationLRepository)
        {
            _lookupInsuranceExplanationLRepository1 = lookupInsuranceExplanationLRepository;
        }

        public void Add(LookupInsuranceExplanationL lookupInsuranceExplanationL)
        {
            _lookupInsuranceExplanationLRepository1.Add(lookupInsuranceExplanationL);
        }

        public void Delete(int InsuranceExplanationId)
        {
            _lookupInsuranceExplanationLRepository1.Delete(new LookupInsuranceExplanationL { InsuranceExplanationId = InsuranceExplanationId });

        }

        public List<LookupInsuranceExplanationL> GetAll()
        {
            return _lookupInsuranceExplanationLRepository1.GetList();
        }

        public void Update(LookupInsuranceExplanationL lookupInsuranceExplanationL)
        {
            _lookupInsuranceExplanationLRepository1.Update(lookupInsuranceExplanationL);
        }
    }
}
