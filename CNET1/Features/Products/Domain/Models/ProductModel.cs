using CNET1.Features.Products.Domain.Exceptions;

namespace CNET1.Features.Products.Domain.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public required string Sku { get; set; }
        public required string Name { get; set; }
        public required int CategoryId { get; set; }
        public required string Description { get; set; }
        public double UnitPrice { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = false;
        public int UnitsInStock { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public ProductModel() { }

        public ProductModel(string? sku, string? name, int category, string? description, double unitPrice, string? imageUrl, int unitsInStock)
        {
            Sku = sku ?? throw new ProductModelException("SKU cannot be null");
            Name = name ?? throw new ProductModelException("Name cannot be null");
            CategoryId = category;
            Description = description;
            UnitPrice = unitPrice;
            ImageUrl = imageUrl;
            UnitsInStock = unitsInStock;
        }

    }
}
