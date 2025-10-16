using CNET1.Features.Products.Domain.Enums;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Ports;
using CNET1.Features.Products.Domain.Services;
using CNET1.Features.Products.Domain.Utils;
using CNET1.Utils;

namespace CNET1.Features.Products.Application
{
    public class ProductQueryApplication(
        IProductQueryOutRepository productQueryRepository,
        AppBaseUtil<ProductQueryApplication> baseUtil) :
        AppServiceUtil<ProductQueryApplication>(baseUtil), IProductQueryService
    {
        public Task<ProductModel?> FindBySkuAsync(string sku)
        {
            StartMethod(nameof(FindBySkuAsync));

            // Validate SKU is not null or empty
            if (AppObjectUtil.IsNull(sku))
            {
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.SKU_BLANK);
            }

            EndMethod(nameof(FindBySkuAsync));
            return productQueryRepository.FindOneBySkuAsync(sku);
        }

        public async Task<ProductModel> GetOneProductAsync(string sku)
        {
            StartMethod(nameof(GetOneProductAsync));


            ProductModel? productFound = await FindBySkuAsync(sku);

            if (productFound == null)
            {
                InfoMethod(nameof(GetOneProductAsync), $"Does not exist this SKU: {sku}");
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.PRODUCT_NOT_EXIST);
            }

            EndMethod(nameof(GetOneProductAsync));
            return productFound;
        }
    }
}
