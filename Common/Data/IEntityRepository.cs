using Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdAsync(int id);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> GetList(Expression<Func<T, bool>> filter = null);
    }
}
