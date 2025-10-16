using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Domain.Ports
{
    public interface IProductQueryOutRepository
    {
        Task<ProductModel?> FindOneBySkuAsync(string sku);
    }
}
