using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupProvinceLService
    {
        List<LookupProvinceL> GetAll();
        void Add(LookupProvinceL lookupProvinceL);
        void Update(LookupProvinceL lookupProvinceL);
        void Delete(int Id11);
    }
}
