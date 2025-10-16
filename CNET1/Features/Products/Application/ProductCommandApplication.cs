using CNET1.Features.Products.Domain.Enums;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.PORTS;
using CNET1.Features.Products.Domain.Services;
using CNET1.Features.Products.Domain.Utils;
using CNET1.Utils;

namespace CNET1.Features.Products.Application
{
    public class ProductCommandApplication(
        IProductValidationService productValidationService,
        IProductCommandOutRepository productCommandRepository,
        IProductQueryService productQueryApplication,
        AppBaseUtil<ProductCommandApplication> baseUtil)
        : AppServiceUtil<ProductCommandApplication>(baseUtil), IProductCommandService
    {
        public async Task<ProductModel> CreateOneProductAsync(ProductModel product)
        {
            StartMethod(nameof(CreateOneProductAsync));

            // Validate unique SKU here
            InfoMethod(nameof(CreateOneProductAsync), $"Validating SKU:{product.Sku}");
            ProductModel? productFound = await productQueryApplication.FindBySkuAsync(product.Sku);

            if (productFound != null)
            {
                InfoMethod(nameof(CreateOneProductAsync), $"Already exists this SKU: {product.Sku}");
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.SKU_REPEATED);
            }

            // Rest of validations
            productValidationService.IsValidaForSaving(product);

            InfoMethod(nameof(CreateOneProductAsync), $"Creating product with SKU: {product.Sku}");

            // Set variables of product
            product.IsActive = true;
            product.DateCreated = DateTime.UtcNow;

            EndMethod(nameof(CreateOneProductAsync));
            return await productCommandRepository.SaveOneAsync(product);
        }
    }
}
