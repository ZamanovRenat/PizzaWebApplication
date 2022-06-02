using Microsoft.EntityFrameworkCore;
using PizzaWebApplication.Models;

namespace PizzaWebApplication.Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Pizzas.db");
        }
    }
}
