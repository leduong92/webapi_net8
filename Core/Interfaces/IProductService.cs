using Core.DTO.RequestDto;
using Core.Entities;
using Core.Model;

namespace Core.Interfaces
{
    public interface IProductService
    {
        Task<PagedResult<ProductResponseDto>> ListProducts(PagingWithTimeRequestDTO request);
        Task<List<ProductResponseDto>> ListProductByCategory(Guid categoryId);
        Task<ProductResponseDto> AddSingle(ProductRequestDto request);
        Task<ProductResponseDto> UpdateSingle(ProductRequestDto request);
        Task<int> DeleteSingle(ProductRequestDto request);
        Task<ProductResponseDto> GetByID(Guid id);
    }
}