using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface ICaseService
    {
        List<Case> GetAll();
        void Add(Case @case);
        void Update(Case @case);
        void Delete(int CaseId);
        Case GetById(int CaseId);
    }
}
