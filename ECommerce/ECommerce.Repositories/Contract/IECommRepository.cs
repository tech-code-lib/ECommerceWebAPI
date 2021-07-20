using ECommerce.DAL.Shared;
using ECommerce.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Contract
{
    public interface IECommRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);
        
        void DeleteRange(Func<TEntity, bool> where);
                
        Task<IEnumerable<TEntity>> GetAllAsync();
                
        Task<TEntity> GetByIDAsync(int id);
                
        Task<IEnumerable<TEntity>> GetFilteredAsync(Expression<Func<TEntity, bool>> where);
                
        Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> GetQueryable();

        IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> where, params string[] include);

        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> where);

        void Update(TEntity entity);
    }
}
