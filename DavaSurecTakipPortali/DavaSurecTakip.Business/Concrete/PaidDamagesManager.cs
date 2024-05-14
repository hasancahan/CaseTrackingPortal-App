using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class PaidDamagesManager : IPaidDamagesService
    {
        private IPaidDamagesRepository _paidDamagesRepository;
        public PaidDamagesManager(IPaidDamagesRepository paidDamagesRepository)
        {
            _paidDamagesRepository = paidDamagesRepository;
        }
        public void Add(PaidDamages paidDamages)
        {
            _paidDamagesRepository.Add(paidDamages);
        }

        public void Delete(int RowNumb)
        {
            _paidDamagesRepository.Delete(new PaidDamages {RowNumb=RowNumb});
        }

        public List<PaidDamages> GetAll()
        {
            return _paidDamagesRepository.GetList();
        }

        public void Update(PaidDamages paidDamages)
        {
            _paidDamagesRepository.Update(paidDamages);
        }
    }
}
