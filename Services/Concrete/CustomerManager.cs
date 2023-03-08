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
        public CustomerManager(IEntityRepository<Customers> entityRepository, IUnitOfWork unitOfWork) : base(entityRepository, unitOfWork)
        {
        }

    }
}
