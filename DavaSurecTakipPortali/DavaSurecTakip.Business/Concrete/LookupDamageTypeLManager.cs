using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupDamageTypeLManager : ILookupDamageTypeLService
    {

        private ILookupDamageTypeLRepository _lookupDamageTypeLRepository;
        public LookupDamageTypeLManager(ILookupDamageTypeLRepository lookupDamageTypeLRepository)
        {
            _lookupDamageTypeLRepository = lookupDamageTypeLRepository;
        } 

        public void Add(LookupDamageTypeL lookupDamageTypeL)
        {
            _lookupDamageTypeLRepository.Add(lookupDamageTypeL);
        }

        public void Delete(int DamageTypeId)
        {
            _lookupDamageTypeLRepository.Delete(new LookupDamageTypeL { DamageTypeId = DamageTypeId });

        }

        public List<LookupDamageTypeL> GetAll()
        {
            return _lookupDamageTypeLRepository.GetList();
        }

        public void Update(LookupDamageTypeL lookupDamageTypeL)
        {
            _lookupDamageTypeLRepository.Update(lookupDamageTypeL);
        }
    }
}
