using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupWorkAreaLService
    {
        List<LookupWorkAreaL> GetAll();
        void Add(LookupWorkAreaL lookupWorkAreaL);
        void Update(LookupWorkAreaL lookupWorkAreaL);
        void Delete(int Id12);
    }
}
