using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Categories : IEntity
    {
        [Key]
        public int CategoryID { get; set; }

        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        public byte[]? Picture { get; set; }


    }
}
