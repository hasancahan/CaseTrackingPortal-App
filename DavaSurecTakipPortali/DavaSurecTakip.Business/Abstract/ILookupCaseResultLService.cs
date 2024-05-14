using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupCaseResultLService
    {
        List<LookupCaseResultL> GetAll();
        void Add(LookupCaseResultL lookupCaseResultL);
        void Update(LookupCaseResultL lookupCaseResultL);
        void Delete(int Id2);

    }
}
