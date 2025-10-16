namespace CNET1.Features.Products.Adapters.DTO
{
    public class ProductSingleReponseDTO
    {
        public required string Sku { get; set; }
        public required string Name { get; set; }
        public required int CategoryId { get; set; }
        public required string Description { get; set; }
        public string? ImageUrl { get; set; }
        public double UnitPrice { get; set; }
        public bool IsActive { get; set; } = false;
        public int UnitsInStock { get; set; }
        public required string DateCreated { get; set; }
        public string? LastUpdated { get; set; }

        public ProductSingleReponseDTO() { }
    }
}
