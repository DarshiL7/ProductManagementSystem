using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        
        public string UserName { get; set; }

      

        
        public string UserMobile { get; set; }

        
        public string UserAddress { get; set; }
    }
}
