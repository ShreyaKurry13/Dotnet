using Microsoft.EntityFrameworkCore;
using Sales;

namespace DemoApp.Shopping.Data;


public class ShopDbContext(DbContextOptions options) : DbContext(options)
{
   public DbSet<Product> Products {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        .modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(p => p.Id)
            .HasColumnName("ProductNo");
         .modelBuilder.Entity<>()
            .ToTable("ProductInfo")
            .Property(p => p.Id)
            .HasColumnName("ProductNo");
         .modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(p => p.Id)
            .HasColumnName("ProductNo");
    }
}




