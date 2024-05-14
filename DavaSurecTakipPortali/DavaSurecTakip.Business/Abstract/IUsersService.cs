using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DavaSurecTakip.Business.Abstract
{
    public interface IUsersService
    {
        List<Users> GetAll();   
        void Add(Users users);
        void Update(Users users);
        void Delete(int Id);
        Users GetById(int Id);

    }
}
