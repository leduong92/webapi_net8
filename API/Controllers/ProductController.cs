using API.Extensions;
using Core.DTO.RequestDto;
using Core.Interfaces;
using Core.Model;
using Infrastructure.HelperService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ProductController : BaseApiController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("search")]
    public async Task<IActionResult> ListPaging([FromBody] PagingWithTimeRequestDTO request)
    {
        var results = await _productService.ListProducts(request);

        return Ok(results);
    }
    [HttpGet]
    public async Task<IActionResult> ListsPaging([FromQuery] PagingWithTimeRequestDTO request)
    {
        var results = await _productService.ListProducts(request);

        return Ok(results);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var results = await _productService.GetByID(id);
        if (results == null)
            return BadRequest($"Cannot find product {id}");
        return Ok(results);
    }

    [HttpGet("category/{categoryId}")]
    public async Task<IActionResult> GetProductByCategoryId(Guid categoryId)
    {
        var results = await _productService.ListProductByCategory(categoryId);
        if (results == null)
            return BadRequest($"Cannot find product by category {categoryId}");
        return Ok(results);
    }

    [HttpGet("featureds")]
    public async Task<IActionResult> ListFeatureds()
    {
        var results = await _productService.ListFeatureds();
        if (results == null)
            return BadRequest($"Cannot find list featureds");
        return Ok(results);
    }
    [HttpGet("newproducts")]
    public async Task<IActionResult> ListNewProducts()
    {
        var results = await _productService.ListNewProducts();
        if (results == null)
            return BadRequest($"Cannot find list new products");
        return Ok(results);
    }
    [HttpPost]
    public async Task<IActionResult> AddSingle([FromForm] ProductRequestDto request)
    {
        var results = await _productService.AddSingle(request);
        if (results == null)
            return BadRequest($"Cannot add product");
        return Ok(results);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateSingle([FromForm] ProductRequestDto request)
    {
        var results = await _productService.UpdateSingle(request);
        if (results == null)
            return BadRequest($"Cannot update product");
        return Ok(results);
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteSingle([FromBody] ProductRequestDto request)
    {
        var results = await _productService.DeleteSingle(request);
        if (results == 0)
            return BadRequest($"Cannot delete product {request.Id}");
        return Ok(results);
    }
}
