using Microsoft.EntityFrameworkCore;
using PizzaWebApplication.Models;

namespace PizzaWebApplication.Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Section> Sections { get; set; }
        public PizzaContext(DbContextOptions<PizzaContext> dbContextOptions) : base(dbContextOptions)
        {
            //Пересоздание БД
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Pizzas.db");
        }
    }
}
