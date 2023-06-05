using Microsoft.EntityFrameworkCore;
using ADA.ShoppingKart.Models.Entities;

namespace ADA.ShoppingKart.Database
{
    public class ShoppingKartDBContext : DbContext
    {
        public ShoppingKartDBContext(DbContextOptions<ShoppingKartDBContext> options) : base(options)
        {

        }

        public DbSet<User> Actions { get; set; }
        public DbSet<Product> Modules { get; set; }

    }
}
