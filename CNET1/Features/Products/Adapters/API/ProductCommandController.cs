using CNET1.Features.Products.Adapters.DTO;
using CNET1.Features.Products.Adapters.Mappers;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CNET1.Features.Products.Adapters.API
{
    [Route("product")]
    [ApiController]
    [Tags("Product")]
    public class ProductCommandController(
        IProductCommandService productCommandApp,
        AppBaseUtil<ProductCommandController> baseUtil)
        : AppControllerUtil<ProductCommandController>(baseUtil)
    {

        [HttpPost("create")]
        [EndpointSummary("Create a new product")]
        [EndpointDescription("We need an object for creating")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateOneProductAsync(
            [FromBody] ProductCreateRequestDTO request)
        {
            StartMethod(nameof(CreateOneProductAsync));

            ProductModel productCreated = await productCommandApp.CreateOneProductAsync(ProductMapper.ToProductModel(request));

            EndMethod(nameof(CreateOneProductAsync));
            return Ok(ProductMapper.ToProductCreateResponseDTO(productCreated));
        }
    }
}
