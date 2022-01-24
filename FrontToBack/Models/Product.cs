﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,MinLength(5)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ProductPhoto;
    }
}
