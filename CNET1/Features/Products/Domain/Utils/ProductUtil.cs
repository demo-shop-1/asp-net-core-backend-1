using CNET1.Features.Products.Domain.Enums;
using CNET1.Features.Products.Domain.Exceptions;

namespace CNET1.Features.Products.Domain.Utils
{
    public class ProductUtil
    {
        public static ProductValidationException ThrowValidationError(ProductMessageEnum message)
        {
            return new ProductValidationException(message.Code, message.Message);
        }
    }
}
