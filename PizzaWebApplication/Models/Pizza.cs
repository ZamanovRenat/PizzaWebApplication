using System.ComponentModel.DataAnnotations;

namespace PizzaWebApplication.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тесто: тонкое || традиционное
        /// </summary>
        public string Dough { get; set; }
        /// <summary>
        /// Диаметр пиццы
        /// </summary>
        public int Diam { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Фото пиццы
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
