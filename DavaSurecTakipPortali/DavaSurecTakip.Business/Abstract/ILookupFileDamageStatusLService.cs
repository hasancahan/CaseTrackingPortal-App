using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupFileDamageStatusLService
    {
        List<LookupFileDamageStatusL> GetAll();
        void Add(LookupFileDamageStatusL lookupFileDamageStatusL);
        void Update(LookupFileDamageStatusL lookupFileDamageStatusL);
        void Delete(int Id6);
    }
}
