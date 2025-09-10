namespace CNET1.Features.Products.Adapters.Web
{
    public class ProductController
    {
        protected readonly ILogger<ProductController> logger = LoggerFactory
            .Create(builder => { })
            .CreateLogger<ProductController>();

        protected void InfoMethod(string NameMethod, string Message) { 
            logger.LogInformation(message: $"Info > {NameMethod}: {Message}");
        }
    }
}
