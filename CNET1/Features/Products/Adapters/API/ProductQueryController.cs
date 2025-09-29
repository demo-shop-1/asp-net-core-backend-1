using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CNET1.Features.Products.Adapters.Web
{
    [ApiController]
    [Route("product")]
    [Tags("Product")]
    public class ProductQueryController(
        IProductQueryService productQueryApplication,
        ILogger<ProductQueryController> logger) : AppControllerUtil<ProductQueryController>(logger)
    {
        private readonly IProductQueryService _productQueryService = productQueryApplication;

        [HttpGet("{sku}")]
        [EndpointSummary("Get one product")]
        [EndpointDescription("We will get one product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetOneProduct(
            [Description("SKU code product")]
            string sku)
        {
            StartMethod(nameof(GetOneProduct));

            ProductModel product = await _productQueryService.GetOneProductAsync(sku);

            EndMethod(nameof(GetOneProduct));
            return Ok(product);
        }
    }
}
