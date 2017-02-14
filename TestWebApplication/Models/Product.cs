using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="This is required field.")]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage ="Range is required field.")]
        [Range(1,1000,ErrorMessage ="Value must be in the range of 1 to 1000.")]
        public double Price { get; set; }
        public string Description { get; set; }


    }
}