﻿using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ProductDto:BaseDto
    {
        [Key]
        public int ProductID { get; set; }

        public string? ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public Int16? UnitsInStock { get; set; }

        //public Int16? UnitsOnOrder { get; set; }

        //public Int16? ReorderLevel { get; set; }
    }
}
