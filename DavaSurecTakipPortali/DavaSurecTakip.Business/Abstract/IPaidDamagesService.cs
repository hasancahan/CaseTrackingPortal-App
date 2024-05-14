using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface IPaidDamagesService
    {
        List<PaidDamages> GetAll();
        void Add(PaidDamages paidDamages);
        void Update(PaidDamages paidDamages);
        void Delete(int RowNumb);
    }
}
