using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

  
        public string ProductName { get; set; }

  
        public int ProductPrice { get; set; }

        
        public int ProductQuantity { get; set; }

        public int ProductDiscount { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        
    }
}
