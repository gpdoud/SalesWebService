using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebService.Models;

namespace SalesWebService.Data
{
    public class SalesDbServiceContext : DbContext
    {
        public SalesDbServiceContext (DbContextOptions<SalesDbServiceContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebService.Models.Customer> Customers { get; set; }
        public DbSet<SalesWebService.Models.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>(e => {
                e.HasIndex("Code").IsUnique();
            });
        }
    }
}
