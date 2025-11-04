using System.ComponentModel.DataAnnotations;

namespace GestionPortal.web.Models.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Category { get; set; }
    }
}
