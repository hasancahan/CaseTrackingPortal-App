using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupLevyInfoLService
    {
        List<LookupLevyInfoL> GetAll();
        void Add(LookupLevyInfoL lookupLevyInfoL);
        void Update(LookupLevyInfoL lookupLevyInfoL);
        void Delete(int Id9);

    }
}
