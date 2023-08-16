using Core.DTO.RequestDto;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CollectionController : BaseApiController
{
    private readonly ICollectionService _collectionService;

    public CollectionController(ICollectionService collectionService)
    {
        _collectionService = collectionService;
    }

    [HttpGet]
    public async Task<List<CollectionResponseDto>> Get([FromQuery] PagingWithTimeRequestDTO request)
    {
        var results = await _collectionService.ListCollections(request);

        return results;
    }
}
