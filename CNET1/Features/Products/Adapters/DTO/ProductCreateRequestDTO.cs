using System.ComponentModel.DataAnnotations;

namespace CNET1.Features.Products.Adapters.DTO
{
    public class ProductCreateRequestDTO
    {
        [Required]
        [MinLength(4)]
        public required string Sku { get; set; }

        [Required]
        [MaxLength(500)]
        public required string Name { get; set; }

        [Required]
        public required int CategoryId { get; set; }

        [Required]
        [MaxLength(2000)]
        public required string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "UnitPrice must be a positive value.")]
        public required double UnitPrice { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "UnitsInStock must be a non-negative integer.")]
        public required int UnitsInStock { get; set; }
        public string? ImageUrl { get; set; }
    }
}
