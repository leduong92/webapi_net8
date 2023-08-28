using Core.DTO.RequestDto;
using Core.Interfaces;
using Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ProductController : BaseApiController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<PagedResult<ProductResponseDto>> ListPaging([FromQuery] PagingWithTimeRequestDTO request)
    {
        var results = await _productService.ListProducts(request);

        return results;
    }
    [HttpGet("{id}")]
    public async Task<ProductResponseDto> GetById(Guid id)
    {
        var results = await _productService.GetByID(id);

        return results;
    }
    [HttpGet("category/{categoryId}")]
    public async Task<List<ProductResponseDto>> GetProductByCategoryId(Guid categoryId)
    {
        var results = await _productService.ListProductByCategory(categoryId);

        return results;
    }
    [HttpPost]
    public async Task<ProductResponseDto> AddSingle([FromForm] ProductRequestDto request)
    {
        var results = await _productService.AddSingle(request);

        return results;
    }
    [HttpPut]
    public async Task<ProductResponseDto> UpdateSingle([FromForm] ProductRequestDto request)
    {
        var results = await _productService.UpdateSingle(request);

        return results;
    }
    [HttpDelete]
    public async Task<int> DeleteSingle([FromBody] ProductRequestDto request)
    {
        var results = await _productService.DeleteSingle(request);

        return results;
    }
}
