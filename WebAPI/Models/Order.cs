using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string NameOnCard { get; set; }

        public string CardNumber { get; set; }

        public string ExpMonth { get; set; }

        public double Amount { get; set; }

        public string Bill { get; set; }




    }
}
