using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Domain.Services
{
    public interface IProductQueryService
    {
        Task<ProductModel> GetOneProductAsync(string sku);
    }
}
