using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupFileDamageStatusLManager : ILookupFileDamageStatusLService
    {

        private ILookupFileDamageStatusLRepository _lookupFileDamageStatusLRepository1;
        public LookupFileDamageStatusLManager(ILookupFileDamageStatusLRepository lookupFileDamageStatusLRepository)
        {
            _lookupFileDamageStatusLRepository1 = lookupFileDamageStatusLRepository;
        }
        public void Add(LookupFileDamageStatusL lookupFileDamageStatusL)
        {
            _lookupFileDamageStatusLRepository1.Add(lookupFileDamageStatusL);
        }

        public void Delete(int DamageStatusId)
        {
            _lookupFileDamageStatusLRepository1.Delete(new LookupFileDamageStatusL { DamageStatusId = DamageStatusId });
        }

        public List<LookupFileDamageStatusL> GetAll()
        {
            return _lookupFileDamageStatusLRepository1.GetList();
        }

        public void Update(LookupFileDamageStatusL lookupFileDamageStatusL)
        {
            _lookupFileDamageStatusLRepository1.Update(lookupFileDamageStatusL);
        }
    }
}
