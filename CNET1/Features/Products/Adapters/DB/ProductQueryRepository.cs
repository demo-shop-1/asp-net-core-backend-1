using CNET1.Configuration;
using CNET1.Features.Products.Adapters.Mappers;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Ports;
using Microsoft.EntityFrameworkCore;

namespace CNET1.Features.Products.Adapters.DB
{
    public class ProductQueryRepository(AppDbContext dbContext) : IProductQueryOutRepository
    {
        public async Task<ProductModel?> FindOneBySkuAsync(string sku)
        {
            return await dbContext.Products
                .Where(x => x.Sku == sku)
                .Select(x => ProductMapper.ToProductModel(x))
                .FirstOrDefaultAsync();
        }
    }
}
