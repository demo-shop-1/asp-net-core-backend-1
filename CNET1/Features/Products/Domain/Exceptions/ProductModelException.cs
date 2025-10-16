using CNET1.Exceptions;

namespace CNET1.Features.Products.Domain.Exceptions
{
    public class ProductModelException(string message) : AppException(message)
    {
    }
}
