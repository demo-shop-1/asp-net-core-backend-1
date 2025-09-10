using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CNET1.Features.Products.Adapters.Web
{
    [ApiController]
    [Route("product")]
    [Tags("Product")]
    public class ProductQueryController(ILogger<ProductQueryController> logger) : AppControllerUtil<ProductQueryController>(logger)
    {
        [HttpGet("{sku}")]
        [EndpointSummary("Get one product")]
        [EndpointDescription("We will get one product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetOneProduct(
            [Description("SKU code product")]
            string sku)
        {
            StartMethod(nameof(GetOneProduct));
            EndMethod(nameof(GetOneProduct));
            return Ok($"Product with ID {sku} retrieved");
        }
    }
}
