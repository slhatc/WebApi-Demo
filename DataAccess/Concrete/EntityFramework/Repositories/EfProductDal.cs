﻿using Common.Data.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfProductDal : EfRepositoryBase<Products>, IProductDal
    {
        public EfProductDal(DbContext context) : base(context)
        {

        }
    }
}
