using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupPaymentTypeLManager : ILookupPaymentTypeLService
    {

        private ILookupPaymentTypeLRepository _lookupPaymentTypeLRepository;
        public LookupPaymentTypeLManager(ILookupPaymentTypeLRepository lookupPaymentTypeLRepository)
        {
            _lookupPaymentTypeLRepository = lookupPaymentTypeLRepository;
        }
        public void Add(LookupPaymentTypeL lookupPaymentTypeL)
        {
            _lookupPaymentTypeLRepository.Add(lookupPaymentTypeL);
        }

        public void Delete(int PaymentTypeId)
        {
            _lookupPaymentTypeLRepository.Delete(new LookupPaymentTypeL { PaymentTypeId = PaymentTypeId });

        }

        public List<LookupPaymentTypeL> GetAll()
        {
            return _lookupPaymentTypeLRepository.GetList();
        }

        public void Update(LookupPaymentTypeL lookupPaymentTypeL)
        {
            _lookupPaymentTypeLRepository.Update(lookupPaymentTypeL);
        }
    }
}
