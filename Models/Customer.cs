using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }

       

        [Required]
        public string CustomerMobile { get; set; }

        [Required]
        public string CustomerAddress { get; set; }
    }
}
