using DavaSurecTakip.Shared.Entities;
using DavaSurecTakip.Shared.IRepositoryDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DavaSurecTakip.DataAccess.EntityFramework
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
        
    {
        protected readonly TContext _context;
        protected DbSet<TEntity> DbSet;

        //public EntityRepositoryBase(TContext context)
        //{

        //    DbSet = context.Set<TEntity>();
        //    _context = context;
        //}

        public void Add(TEntity entitiy)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            //DbSet.Add(entitiy);

        }

        public void Delete(TEntity entitiy)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entitiy);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public void Dispose()
        {
            _context.Dispose();

        }

        public TEntity GetById(string id)
        {
           return DbSet.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public void Update(TEntity entitiy)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entitiy);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }

}
