using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupProvinceLManager : ILookupProvinceLService
    {

        private ILookupProvinceLRepository _lookupProvinceLRepository;
        public LookupProvinceLManager(ILookupProvinceLRepository lookupProvinceLRepository)
        {
            _lookupProvinceLRepository = lookupProvinceLRepository;
        }
        public void Add(LookupProvinceL lookupProvinceL)
        {
            _lookupProvinceLRepository.Add(lookupProvinceL);
        }

        public void Delete(int ProvinceId)
        {
            _lookupProvinceLRepository.Delete(new LookupProvinceL { ProvinceId = ProvinceId });

        }

        public List<LookupProvinceL> GetAll()
        {
            return _lookupProvinceLRepository.GetList();
        }

        public void Update(LookupProvinceL lookupProvinceL)
        {
            _lookupProvinceLRepository.Update(lookupProvinceL);
        }
    }
}
