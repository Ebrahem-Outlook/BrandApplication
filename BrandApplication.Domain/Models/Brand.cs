﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Domain.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string? BrandName { get; set; }

        public ICollection<ProductModel>? Models { get; set; }
    }
}
