using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Product
    {
        [Key]
        public int Id{get; set;}
        [Required(ErrorMessage ="Name is required")]
        public required string Name{get; set;}
        [Required(ErrorMessage ="Price is required")]
        public int Price {get; set;}

        [Required(ErrorMessage ="Quantity is required")]
        public int Quantity {get; set;}
        public required string Category {get; set;}
    }
}