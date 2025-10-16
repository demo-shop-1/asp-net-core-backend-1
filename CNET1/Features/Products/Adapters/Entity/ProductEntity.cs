using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNET1.Features.Products.Adapters.Entity
{
    [Table("products")]
    public class ProductEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MinLength(4)]
        public required string Sku { get; set; }

        [Required]
        [MaxLength(500)]
        public required string Name { get; set; }

        [Required]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Required]
        public required string Description { get; set; }

        [Column("image_url")]
        public string? ImageUrl { get; set; }

        [Required]
        [Column("unit_price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrice must be a positive value.")]
        public double UnitPrice { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "UnitsInStock must be a non-negative integer.")]
        [Column("units_in_stock")]
        public int UnitsInStock { get; set; }

        [Required]
        [Column("date_created")]
        public DateTime DateCreated { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        public ProductEntity() { }
    }
}
