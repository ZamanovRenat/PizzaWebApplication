using System.ComponentModel.DataAnnotations;

namespace PizzaWebApplication.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Наименование категории пиццы
        /// </summary>
        public string Name { get; set; }
    }
}
