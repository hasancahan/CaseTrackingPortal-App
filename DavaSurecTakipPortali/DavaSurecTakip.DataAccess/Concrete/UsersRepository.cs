using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.DataAccess.EntityFramework;
using DavaSurecTakip.Entities.DbEntitiesModels;
using Microsoft.EntityFrameworkCore;

namespace DavaSurecTakip.DataAccess.Concrete
{
    public class UsersRepository : EntityRepositoryBase<Users, Context>, IUsersRepository
    {
        
    }
}
    