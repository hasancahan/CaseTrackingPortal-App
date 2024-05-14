using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupFileStageLService
    {
        List<LookupFileStageL> GetAll();
        void Add(LookupFileStageL lookupFileStageL);
        void Update(LookupFileStageL lookupFileStageL);
        void Delete(int Id7);
    }
}
