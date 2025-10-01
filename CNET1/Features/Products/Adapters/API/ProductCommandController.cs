using CNET1.Features.Products.Adapters.DTO;
using CNET1.Features.Products.Adapters.Mappers;
using CNET1.Features.Products.Domain.Models;
using CNET1.Features.Products.Domain.Services;
using CNET1.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CNET1.Features.Products.Adapters.Web
{
    [Route("product")]
    [ApiController]
    [Tags("Product")]
    public class ProductCommandController(
        IProductCommandService productCommandApplication,
        AppBaseUtil<ProductCommandController> baseUtil)
        : AppControllerUtil<ProductCommandController>(baseUtil)
    {

        [HttpPost("create")]
        [EndpointSummary("Create a new product")]
        [EndpointDescription("We need an object for creating")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateProduct(
            [FromBody] ProductCreateRequestDTO request)
        {
            StartMethod(nameof(CreateProduct));

            ProductModel productCreated = await productCommandApplication.CreateProductAsync(ProductMapper.ToProductModel(request));

            EndMethod(nameof(CreateProduct));
            return Ok(ProductMapper.ToProductCreateResponseDTO(productCreated));
        }
    }
}
