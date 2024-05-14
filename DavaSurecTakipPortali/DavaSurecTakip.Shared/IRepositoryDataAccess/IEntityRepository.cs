using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DavaSurecTakip.Shared.IRepositoryDataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T GetById(string id);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        IQueryable<T> GetAll();
        int SaveChanges();
        void Dispose();
    }
}
