using Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CategoryDto : BaseDto
    {
        //public int CategoryID { get; set; }

        public string? CategoryName { get; set; }

        public string? Description { get; set; }
    }
}
