using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupInsuranceExplanationLService
    {
        List<LookupInsuranceExplanationL> GetAll();
        void Add(LookupInsuranceExplanationL lookupInsuranceExplanationL);
        void Update(LookupInsuranceExplanationL lookupInsuranceExplanationL);
        void Delete(int Id8);
    }
}
