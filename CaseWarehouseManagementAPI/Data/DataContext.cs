using CaseWarehouseManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CaseWarehouseManagementAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("getdate()");
        }
    }
}
