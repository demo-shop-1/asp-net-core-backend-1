using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;

namespace CNET1.Features.Products.Application
{
    public class ProductCommandApplication(
        AppBaseUtil<ProductCommandApplication> baseUtil)
        : AppServiceUtil<ProductCommandApplication>(baseUtil), IProductCommandService
    {
        public Task<ProductModel> CreateProductAsync(ProductModel product)
        {
            StartMethod(nameof(CreateProductAsync));
            EndMethod(nameof(CreateProductAsync));
            throw new NotImplementedException();
        }
    }
}
