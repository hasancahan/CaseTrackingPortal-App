using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupCourtInfoLService
    {
        List<LookupCourtInfoL> GetAll();
        void Add(LookupCourtInfoL lookupCourtInfoL);
        void Update(LookupCourtInfoL lookupCourtInfoL);
        void Delete(int Id4);
    }
}
