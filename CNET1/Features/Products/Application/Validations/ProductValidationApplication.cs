using CNET1.Features.Products.Domain.Enums;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Features.Products.Domain.Utils;
using CNET1.Utils;

namespace CNET1.Features.Products.Application.Validations
{
    public class ProductValidationApplication(
        AppBaseUtil<ProductValidationApplication> baseUtil)
        : AppServiceUtil<ProductValidationApplication>(baseUtil), IProductValidationService

    {
        public bool IsValidaForSaving(ProductModel product)
        {
            bool isValid = true;

            // validate sku
            ValidateSku(product.Sku);

            // validate name
            ValidateName(product.Name);

            // TODO: validate category exists

            return isValid;
        }

        public bool ValidateName(string name)
        {
            bool isValid = true;

            if (AppObjectUtil.IsBlankString(name))
            {
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.NAME_BLANK);
            }
            return isValid;
        }

        public bool ValidateSku(string sku)
        {
            bool isValid = true;

            if (AppObjectUtil.IsBlankString(sku))
            {
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.SKU_BLANK);
            }

            if (sku.Length < ((int)ProductIntegerEnum.SKU_MIN_SIZE))
            {
                throw ProductUtil.ThrowValidationError(ProductMessageEnum.SKU_MIN);
            }

            return isValid;
        }

    }
}
