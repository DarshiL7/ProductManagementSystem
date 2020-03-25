using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Models;

namespace ProductManagementSystem.Data
{
    public class ProductManagementSystemContext : DbContext
    {
        public ProductManagementSystemContext (DbContextOptions<ProductManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<ProductManagementSystem.Models.Product> Products { get; set; }

        public DbSet<ProductManagementSystem.Models.Customer> Customers{ get; set; }

        public DbSet<ProductManagementSystem.Models.User> Users { get; set; }

        public DbSet<ProductManagementSystem.Models.Cart> Carts { get; set; }

        
    }
}
