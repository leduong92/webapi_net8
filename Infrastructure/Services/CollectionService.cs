

using Core.DTO.RequestDto;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Services;

public class CollectionService : ICollectionService
{
    private readonly IUnitOfWork _uow;
    public CollectionService(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<List<CollectionResponseDto>> ListCollections(PagingWithTimeRequestDTO dto)
    {
        var results = await _uow.Repository<Collection>().GetEntityWithSpec(x => x.IsActive != false, null, "");

        var lst = new List<CollectionResponseDto>();

        foreach (var item in results)
        {
            var collection = new CollectionResponseDto()
            {
                Id = item.Id,
                CollectionName = item.CollectionName,
                DisplayName = item.DisplayName,
                SortOrder = item.SortOrder,
                MetaKeyword = item.MetaKeyword,
                MetaDescription = item.MetaDescription,
                UrlCode = item.UrlCode
            };
            lst.Add(collection);
        }

        return lst;
    }


    // public async Task<List<CollectionResponseDto>> ListCollections(PagingWithTimeRequestDTO dto)
    // {
    //     var results = await repository.GetEntityWithSpec(x => x.IsActive != false, null, "");

    //     var lst = new List<CollectionResponseDto>();

    //     foreach (var item in results)
    //     {
    //         var collection = new CollectionResponseDto()
    //         {
    //             Id = item.Id,
    //             CollectionName = item.CollectionName,
    //             DisplayName = item.DisplayName,
    //             SortOrder = item.SortOrder,
    //             MetaKeyword = item.MetaKeyword,
    //             MetaDescription = item.MetaDescription,
    //             UrlCode = item.UrlCode
    //         };
    //         lst.Add(collection);
    //     }

    //     return lst;
    // }
}
