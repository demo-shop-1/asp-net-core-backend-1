using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Domain.PORTS
{
    public interface IProductCommandOutRepository
    {
        Task<ProductModel> SaveOneAsync(ProductModel product);
    }
}
