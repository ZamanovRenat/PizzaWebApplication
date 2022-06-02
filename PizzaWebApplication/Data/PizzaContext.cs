using Microsoft.EntityFrameworkCore;
using PizzaWebApplication.Models;

namespace PizzaWebApplication.Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; } = null!;
        public DbSet<Section> Sections { get; set; } = null!;

        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>().HasData(
                new Section {Id = 1, Name = "Мясная" },
                new Section { Id = 2, Name = "Вегетерианская" },
                new Section { Id = 3, Name = "Гриль" },
                new Section { Id = 4, Name = "Острая" },
                new Section { Id = 5, Name = "Закрытая" }
                );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Чизбургер-пицца", Dough = "Традиционное", Diam  = 30, SectionId = 1, Price = 395},
                new Pizza { Id = 2, Name = "Сырная", Dough = "Традиционное", Diam = 30, SectionId = 2, Price = 450 },
                new Pizza { Id = 3, Name = "Креветки по азиатски", Dough = "Традиционное", Diam = 30, SectionId = 3, Price = 290 },
                new Pizza { Id = 4, Name = "Сырный цыпленок", Dough = "Традиционное", Diam = 30, SectionId = 4, Price = 500 }
                );
        }
    }
}
