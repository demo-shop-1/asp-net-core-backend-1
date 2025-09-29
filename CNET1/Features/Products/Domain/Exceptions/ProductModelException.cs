using CNET1.Exceptions;

namespace CNET1.Features.Products.Domain.Exceptions
{
    public class ProductModelException : AppException
    {
        public ProductModelException(string message) : base(message)
        {
        }
    }
}
