using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CNET1.Features.Products.Adapters.Web
{
    [Route("product")]
    [ApiController]
    [Tags("Product")]
    public class ProductCommandController : ControllerBase
    {

        
        [HttpPost("create")]
        [Tags("create")]
        [EndpointSummary("Create a new product")]
        [EndpointDescription("We need an object for creating")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CreateProduct()
        {
            // Implementation for creating a product
            return Ok("Product created");
        }
    }
}
