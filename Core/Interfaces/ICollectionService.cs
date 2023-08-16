using Core.DTO.RequestDto;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICollectionService
    {
        Task<List<CollectionResponseDto>> ListCollections(PagingWithTimeRequestDTO dto);
    }
}