using ECommerce.DAL.Contexts;
using ECommerce.DAL.Shared;
using ECommerce.DAL.Tables;
using ECommerce.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public class ECommRepository<TEntity> : IECommRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ECommDBContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public ECommRepository(ECommDBContext dbContext)
        {
            _dbContext = dbContext;
            this._dbSet = dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this._dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(Func<TEntity, bool> where)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<TEntity> GetByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetFilteredAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> where, params string[] include)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
