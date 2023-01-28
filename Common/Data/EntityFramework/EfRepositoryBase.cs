using Common.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.EntityFramework
{
    public class EfRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly DbContext _context;
        public EfRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>()
                : _context.Set<TEntity>().Where(filter);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
            return entity;
        }
    }
}
