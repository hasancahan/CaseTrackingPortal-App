using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
   
    public interface ILookupAttornerLService
    {
        List<LookupAttornerL> GetAll();
        void Add(LookupAttornerL lookupAttornerL);
        void Update(LookupAttornerL lookupAttornerL);
        void Delete(int Id);
        LookupAttornerL GetById(int AttornerId);
    }
}
