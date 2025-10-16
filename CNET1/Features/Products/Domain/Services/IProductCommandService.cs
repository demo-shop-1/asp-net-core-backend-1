using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Domain.Services
{
    public interface IProductCommandService
    {
        Task<ProductModel> CreateOneProductAsync(ProductModel product);
    }
}
