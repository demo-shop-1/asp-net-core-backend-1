using CNET1.Features.Products.Adapters.DTO;
using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Adapters.Mappers
{
    public class ProductMapper
    {
        public static ProductModel ToProductModel(ProductCreateRequestDTO dto)
        {
            return new()
            {
                Sku = dto.Sku,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                ImageUrl = dto.ImageUrl
            };
        }

        public static ProductCreateResponseDTO ToProductCreateResponseDTO(ProductModel model)
        {
            return new()
            {
                Sku = model.Sku,
                Name = model.Name,
                CategoryId = model.CategoryId,
                Description = model.Description,
                UnitPrice = model.UnitPrice,
                UnitsInStock = model.UnitsInStock,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive,
                DateCreated = model.DateCreated
            };
        }
    }
}
