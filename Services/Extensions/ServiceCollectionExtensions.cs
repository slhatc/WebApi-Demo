using Common.Data;
using Common.Data.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<DbContext, DatabaseContext>();
            services.AddScoped(typeof(IEntityRepository<>), typeof(EfRepositoryBase<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(Assembly.GetEntryAssembly());
            //services.AddScoped<ICustomerService, CustomerManager>();
            //services.AddScoped<ICustomerDal, EfCustomerDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();

            //services.AddScoped<IProductDal, EfProductDal>();
            //services.AddScoped<ICategoryDal, EfCategoryDal>();
            return services;

        }
        
    }
}
