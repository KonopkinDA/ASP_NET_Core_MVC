using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Storage
{
    public class ProductDataContext : DbContext
    {
        public ProductDataContext(DbContextOptions<ProductDataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Veranda> Verandas { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Country> Countrys { get; set; }

    }
}
