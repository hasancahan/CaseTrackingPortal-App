using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ILookupCaseSubjectLService
    {
        List<LookupCaseSubjectL> GetAll();
        void Add(LookupCaseSubjectL lookupCaseSubjectL);
        void Update(LookupCaseSubjectL lookupCaseSubjectL);
        void Delete(int Id3);
    }
}
