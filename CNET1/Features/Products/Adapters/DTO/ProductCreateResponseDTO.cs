namespace CNET1.Features.Products.Adapters.DTO
{
    public class ProductCreateResponseDTO
    {
        public required string Sku { get; set; }
        public required string Name { get; set; }
        public required int CategoryId { get; set; }
        public required string Description { get; set; }
        public double UnitPrice { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int UnitsInStock { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
