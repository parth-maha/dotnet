using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Product
    {
        [Key]
        public int Id{get; set;}
        [Required]
        public required string Name{get; set;}
        [Required]
        public int Price {get; set;}
        public required string Category {get; set;}
    }
}