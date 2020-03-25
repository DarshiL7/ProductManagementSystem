using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
    }
}
