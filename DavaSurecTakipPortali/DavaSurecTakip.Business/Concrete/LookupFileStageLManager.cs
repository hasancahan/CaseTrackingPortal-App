using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class LookupFileStageLManager : ILookupFileStageLService
    {

        private ILookupFileStageLRepository _lookupFileStageLRepository;
        public LookupFileStageLManager(ILookupFileStageLRepository lookupFileStageLRepository)
        {
            _lookupFileStageLRepository = lookupFileStageLRepository;
        }
        public void Add(LookupFileStageL lookupFileStageL)
        {
            _lookupFileStageLRepository.Add(lookupFileStageL);
        }

        public void Delete(int FileStageId)
        {
            _lookupFileStageLRepository.Delete(new LookupFileStageL { FileStageId = FileStageId });

        }

        public List<LookupFileStageL> GetAll()
        {
            return _lookupFileStageLRepository.GetList();
        }

        public void Update(LookupFileStageL lookupFileStageL)
        {
            _lookupFileStageLRepository.Update(lookupFileStageL);
        }
    }
}
