using CNET1.Features.Products.Domain.Models;

namespace CNET1.Features.Products.Domain.Services
{
    public interface IProductValidationService
    {
        bool IsValidaForSaving(ProductModel product);
        bool ValidateSku(string sku);
        bool ValidateName(string name);
    }
}
