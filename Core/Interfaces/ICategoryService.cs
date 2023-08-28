using Core.DTO.RequestDto;
using Core.Entities;
using Core.Model;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryResponseDto>> ListCategory();
        Task<CategoryResponseDto> AddSingle(CategoryResquestDto request);
        Task<CategoryResponseDto> UpdateSingle(CategoryResquestDto request);
        Task<int> DeleteSingle(CategoryResquestDto request);
        Task<CategoryResponseDto> GetByID(Guid id);
    }
}