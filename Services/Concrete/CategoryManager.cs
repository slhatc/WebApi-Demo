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
    public  class CategoryManager : GenericManager<Categories>, ICategoryService
    {
        public CategoryManager(IEntityRepository<Categories> entityRepository, IUnitOfWork unitOfWork) : base(entityRepository, unitOfWork)
        {

        }
    }
}
