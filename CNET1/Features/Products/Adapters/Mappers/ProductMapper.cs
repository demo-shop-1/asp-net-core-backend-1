using CNET1.Enums;
using CNET1.Features.Products.Adapters.DTO;
using CNET1.Features.Products.Adapters.Entity;
using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Adapters.Mappers
{
    public class ProductMapper
    {
        public static ProductEntity ToProductEntity(ProductModel dto)
        {
            if (dto == null) return null!;

            return new()
            {
                Id = dto.Id,
                Sku = dto.Sku,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                IsActive = dto.IsActive,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                DateCreated = dto.DateCreated,
                LastUpdated = dto.LastUpdated
            };
        }
        public static ProductSingleReponseDTO ToProductSingleResponseDTO(ProductModel dto)
        {
            if (dto == null) return null!;

            return new()
            {
                Sku = dto.Sku,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                IsActive = dto.IsActive,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                DateCreated = dto.DateCreated.ToString(AppDateTimeEnum.DATE_TIME_FORMAT_DEFAULT.ToString()),
                LastUpdated = dto.LastUpdated?.ToString(AppDateTimeEnum.DATE_TIME_FORMAT_DEFAULT.ToString())
            };
        }
        public static ProductModel ToProductModel(ProductEntity dto)
        {
            if (dto == null) return null!;

            return new()
            {
                Id = dto.Id,
                Sku = dto.Sku,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                ImageUrl = dto.ImageUrl,
                IsActive = dto.IsActive,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                DateCreated = dto.DateCreated,
                LastUpdated = dto.LastUpdated
            };
        }

        public static ProductModel ToProductModel(ProductCreateRequestDTO dto)
        {
            if (dto == null) return null!;

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

        public static ProductCreateResponseDTO ToProductCreateResponseDTO(ProductModel dto)
        {
            if (dto == null) return null!;

            return new()
            {
                Sku = dto.Sku,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                ImageUrl = dto.ImageUrl,
                IsActive = dto.IsActive,
                DateCreated = dto.DateCreated.ToString(AppDateTimeEnum.DATE_TIME_FORMAT_DEFAULT.ToString())
            };
        }
    }
}
