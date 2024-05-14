using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupDamageTypeLService
    {
        List<LookupDamageTypeL> GetAll();
        void Add(LookupDamageTypeL lookupDamageTypeL);
        void Update(LookupDamageTypeL lookupDamageTypeL);
        void Delete(int Id5);
    }
}
