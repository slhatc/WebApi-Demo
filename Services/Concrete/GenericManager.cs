using Common.Data;
using Common.Entity;
using DataAccess.Abstract;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, IEntity, new()
    {
        private readonly IEntityRepository<T> _entityRepository;
        protected readonly IUnitOfWork _unitOfWork;


        public GenericManager(IEntityRepository<T> entityRepository,IUnitOfWork unitOfWork)
        {
            _entityRepository = entityRepository;
            _unitOfWork = unitOfWork;
           
        }

        public async Task<T> AddAsync(T entity)
        {
            await _entityRepository.AddAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;  
        }

        public async Task DeleteAsync(T entity)
        {
            await _entityRepository.DeleteAsync(entity);
            await _unitOfWork.SaveAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await  _entityRepository.GetAllAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _entityRepository.GetAsync(filter);
            
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await _entityRepository.GetByIdAsync(id);
      
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return  _entityRepository.GetList(filter);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await _entityRepository.UpdateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }
    }
}
