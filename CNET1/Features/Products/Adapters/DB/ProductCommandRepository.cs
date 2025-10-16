using CNET1.Configuration;
using CNET1.Features.Products.Adapters.Entity;
using CNET1.Features.Products.Adapters.Mappers;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.PORTS;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CNET1.Features.Products.Adapters.DB
{
    public class ProductCommandRepository(AppDbContext dbContext) : IProductCommandOutRepository
    {
        public async Task<ProductModel> SaveOneAsync(ProductModel product)
        {
            EntityEntry<ProductEntity> result = await dbContext.Products.AddAsync(ProductMapper.ToProductEntity(product));
            await dbContext.SaveChangesAsync();
            return ProductMapper.ToProductModel(result.Entity);
        }
    }
}
