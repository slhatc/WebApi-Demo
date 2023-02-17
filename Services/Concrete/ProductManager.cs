using Common.Data;
using DataAccess.Abstract;
using Entities.Concrete;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public  class ProductManager : GenericManager<Products>, IProductService
    {
        private readonly IEntityRepository<Products> _entityRepository;

        private readonly IUnitOfWork _unitOfWork;
        public ProductManager(IEntityRepository<Products> entityRepository, IUnitOfWork unitOfWork) : base(entityRepository,unitOfWork)
        {
            _entityRepository = entityRepository;

            _unitOfWork = unitOfWork;
        }
    }
}
