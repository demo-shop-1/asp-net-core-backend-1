using CNET1.Exceptions;

namespace CNET1.Features.Products.Domain.Exceptions
{
    public class ProductValidationException(string MessageCode, string MessageRaw)
        : AppException(MessageCode, MessageRaw)
    {

    }
}
