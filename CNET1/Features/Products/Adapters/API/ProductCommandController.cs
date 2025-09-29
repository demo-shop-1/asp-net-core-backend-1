using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CNET1.Features.Products.Adapters.Web
{
    [ApiController]
    [Route("product")]
    [Tags("Product")]
    public class ProductCommandController(ILogger<ProductCommandController> logger) : AppControllerUtil<ProductCommandController>(logger)
    {

        [HttpPost("create")]
        [EndpointSummary("Create a new product")]
        [EndpointDescription("We need an object for creating")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreateProduct()
        {
            StartMethod(nameof(CreateProduct));
            // Implementation for getting a product by ID
            EndMethod(nameof(CreateProduct));
            return Ok("Product created");
        }
    }
}
