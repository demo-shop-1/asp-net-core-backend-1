using CNET1.Features.Products.Domain.Exceptions;

namespace CNET1.Features.Products.Domain.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public int Category { get; set; }
        public string? Description { get; set; }
        public double UnitPrice { get; set; }
        public string? ImageUrl { get; set; }
        public Boolean IsActive { get; set; }
        public int UnitsInStock { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public ProductModel(string? sku, string? name, int category, string? description, double unitPrice, string? imageUrl, bool isActive, int unitsInStock) : this(sku)
        {
            Sku = sku ?? throw new ProductModelException("SKU cannot be null");
            Name = name ?? throw new ProductModelException("Name cannot be null");
            Category = category;
            Description = description;
            UnitPrice = unitPrice;
            ImageUrl = imageUrl;
            IsActive = isActive;
            UnitsInStock = unitsInStock;
        }

    }
}
