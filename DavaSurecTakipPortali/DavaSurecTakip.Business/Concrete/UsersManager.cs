using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.DataAccess.Concrete;
using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Concrete
{
    public class UsersManager : IUsersService
    {
        //Burada Data Katmanına erişim sağlayabilmek için IKurumDataAccess interface'nde Dependency Injection metodunu uyguluyoruz. 
        private IUsersRepository _UsersRepository;
        public UsersManager(IUsersRepository UsersRepository)
        {
            _UsersRepository = UsersRepository;
        }

        public void Add(Users users)
        {
            _UsersRepository.Add(users);
        }

        public void Delete(int Id)
        {
            _UsersRepository.Delete(new Users{Id=Id});
        }

        public List<Users> GetAll()
        {
            return _UsersRepository.GetList();
        }

        public Users GetById(int Id)
        {
            return _UsersRepository.Get(p => p.Id == Id);
        }

        public void Update(Users users)
        {
            _UsersRepository.Update(users);
        }
    }
}
