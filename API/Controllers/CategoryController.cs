using Core.DTO.RequestDto;
using Core.Interfaces;
using Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class CategoryController : BaseApiController
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<List<CategoryResponseDto>> Get()
    {
        var results = await _categoryService.ListCategory();

        return results;
    }
    [HttpGet("{id}")]
    public async Task<CategoryResponseDto> GetById(Guid id)
    {
        var results = await _categoryService.GetByID(id);

        return results;
    }

    [HttpPost]
    public async Task<CategoryResponseDto> AddSingle([FromBody] CategoryResquestDto request)
    {
        var results = await _categoryService.AddSingle(request);

        return results;
    }
    [HttpPut]
    public async Task<CategoryResponseDto> UpdateSingle([FromBody] CategoryResquestDto request)
    {
        var results = await _categoryService.UpdateSingle(request);

        return results;
    }
    [HttpDelete]
    public async Task<int> DeleteSingle([FromBody] CategoryResquestDto request)
    {
        var results = await _categoryService.DeleteSingle(request);

        return results;
    }
}
