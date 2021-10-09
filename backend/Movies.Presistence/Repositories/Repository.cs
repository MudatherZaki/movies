using Microsoft.EntityFrameworkCore;
using Movies.Core.Domain;
using Movies.Core.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Presistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected DbSet<TEntity> DbSet { get; set; }
        public DbContext DbContext { get; }

        public Repository(Context applicationContext) 
        {
            DbContext = applicationContext;
            DbSet = DbContext?.Set<TEntity>();
        }
        public void Delete(int id)
        {
            var entity = DbSet.FirstOrDefault(e => e.Id == id);
            DbSet.Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable();
        }

        public Task<IQueryable<TEntity>> GetAllAsync()
        {
            return Task.FromResult(DbSet.AsQueryable());
        }

        public Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.FromResult(DbSet.Where(predicate).AsQueryable());
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return DbSet.FindAsync(id).AsTask();
        }

        public void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void InsertRange(List<TEntity> entity)
        {
            DbSet.AddRange(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;

        }

        public async Task InsertAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);
        }


    }
}
