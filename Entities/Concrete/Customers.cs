﻿using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customers : IEntity
    {
        [Key]
        public char CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string? ContactName { get; set; }

        public string? City { get; set; }

    }
}
