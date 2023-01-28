using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public  class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5OJUM63\\SQLEXPRESS; Database=NORTHWND; Integrated Security=True;");
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
