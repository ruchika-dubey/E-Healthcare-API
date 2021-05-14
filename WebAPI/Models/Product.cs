using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
       [Required]
       
        public string ProductName { get; set; }
        [Required]
    
        public string ImageUrl { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public string ProductType { get; set; }
        public int Qnt { get; set; }


    }
}
