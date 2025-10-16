using CNET1.Features.Products.Adapters.Mappers;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CNET1.Features.Products.Adapters.API
{
    [ApiController]
    [Route("product")]
    [Tags("Product")]
    public class ProductQueryController(
        IProductQueryService productQueryApp,
        AppBaseUtil<ProductQueryController> baseUtil)
        : AppControllerUtil<ProductQueryController>(baseUtil)
    {
        [HttpGet("{sku}")]
        [EndpointSummary("Get one product")]
        [EndpointDescription("We will get one product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOneProductAsync(
            [Description("SKU code product")]
            string sku)
        {
            StartMethod(nameof(GetOneProductAsync));

            ProductModel productFound = await productQueryApp.GetOneProductAsync(sku);

            EndMethod(nameof(GetOneProductAsync));
            return Ok(ProductMapper.ToProductSingleResponseDTO(productFound));
        }
    }
}
