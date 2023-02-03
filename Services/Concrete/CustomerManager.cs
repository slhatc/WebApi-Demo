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
    public class CustomerManager : GenericManager<Customers>, ICustomerService
    {
        private readonly IEntityRepository<Customers> _entityRepository;
        private readonly ICustomerService _customerService;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerManager(IEntityRepository<Customers> entityRepository, ICustomerService customerService,IUnitOfWork unitOfWork):base(entityRepository,unitOfWork)
        {
            _entityRepository = entityRepository;
            _customerService = customerService;
            _unitOfWork = unitOfWork;
        }
    }
}
