using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private EfCustomerDal _customerDal;
        private EfProductDal _productDal;
        private EfCategoryDal _categoryDal;

        public UnitOfWork(DbContext context)
        {
            _context = context;
           
        }

        public ICustomerDal Customers => _customerDal ?? new EfCustomerDal(_context);
        public IProductDal Products => _productDal ?? new EfProductDal(_context);
        public ICategoryDal Categories => _categoryDal ?? new EfCategoryDal(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
