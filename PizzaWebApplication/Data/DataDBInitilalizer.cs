using PizzaWebApplication.Models;

namespace PizzaWebApplication.Data
{
    public class DataDBInitilalizer
    {
        private readonly PizzaContext _db;

        public DataDBInitilalizer(PizzaContext db) => _db = db;

        public void Initialize()
        {
            //Пересоздание БД
            _db.Database.EnsureDeleted();
            _db.Database.EnsureCreated();
            //Создание и добавление категорий
            Section Meet = new Section() { Name = "Мясная" };
            Section Vegeterian = new Section() { Name = "Вегетерианская" };
            Section Grill = new Section() { Name = "Гриль" };
            Section Spicy = new Section() { Name = "Острая" };
            Section Closed = new Section() { Name = "Закрытая" };
            _db.Sections.AddRange(Meet, Vegeterian, Grill, Spicy, Closed);

            //Создание добавление пицц
            Pizza CheezBurger = new Pizza() { Name = "Чизбургер-пицца", Section = Meet, Price = 395 };
            Pizza Cheez = new Pizza() { Name = "Сырная", Section = Vegeterian, Price = 450 };
            Pizza ShrimpAsian = new Pizza() { Name = "Креветки по азиатски", Section = Grill, Price = 290 };
            Pizza CheezChicken = new Pizza() { Name = "Сырный цыпленок", Section = Spicy, Price = 500 };

            _db.Pizzas.AddRange(CheezBurger, Cheez, ShrimpAsian, CheezChicken);
            _db.SaveChanges();
        }
    }
}
