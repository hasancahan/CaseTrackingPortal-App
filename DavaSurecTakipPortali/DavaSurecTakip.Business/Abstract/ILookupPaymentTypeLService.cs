using DavaSurecTakip.Entities.DbEntitiesModels;
using System.Collections.Generic;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupPaymentTypeLService
    {
        List<LookupPaymentTypeL> GetAll();
        void Add(LookupPaymentTypeL lookupPaymentTypeL);
        void Update(LookupPaymentTypeL lookupPaymentTypeL);
        void Delete(int Id10);

    }
}
