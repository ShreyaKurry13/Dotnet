using Microsoft.EntityFrameworkCore;

namespace DemoApp.Shopping.Data;

class ShopDbContext : DbContext
{
    public DbSet<Customer> Customers{get; set;}

    public DbSet<Order> Orders{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop10;User Id=dac10;Password=Dac10@1234;Encrypt=False");
    }
}