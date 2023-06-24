using System.ComponentModel.DataAnnotations;

namespace Buoi02_MVC.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
