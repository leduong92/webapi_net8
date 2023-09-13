

using Core.DTO.RequestDto;
using Core.Entities;
using Core.Enums;
using Core.Interfaces;
using Core.Model;
using Infrastructure.HelperService;
using Newtonsoft.Json;

namespace Infrastructure.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _uow;
    public CategoryService(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<CategoryResponseDto> AddSingle(CategoryResquestDto request)
    {
        var category = new Category()
        {
            Name = request.Name,
            DisplayName = request.DisplayName,
            UrlCode = request.UrlCode,
            IsShowOnHome = request.IsShowOnHome,
            SortOrder = request.SortOrder,
            SeoAlias = request.SeoAlias,
            MetaTitle = request.MetaTitle,
            MetaDescription = request.MetaDescription,
            ImageUrl = request.ImageUrl
        };

        _uow.Repository<Category>().Insert(category);
        await _uow.Complete();
        return new CategoryResponseDto()
        {
            Id = category.Id,
            Name = request.Name,
            DisplayName = request.DisplayName,
            UrlCode = request.UrlCode,
            IsShowOnHome = request.IsShowOnHome,
            SortOrder = request.SortOrder,
            SeoAlias = request.SeoAlias,
            MetaTitle = request.MetaTitle,
            MetaDescription = request.MetaDescription,
            ImageUrl = request.ImageUrl
        };
    }
    public async Task<int> DeleteSingle(CategoryResquestDto request)
    {
        var dbResult = await _uow.Repository<Category>().GetByIdAsync(request.Id);

        _uow.Repository<Category>().Delete(dbResult);

        return await _uow.Complete();
    }

    public async Task<CategoryResponseDto> GetByID(Guid id)
    {
        var dbResult = await _uow.Repository<Category>().GetByIdAsync(id);

        return new CategoryResponseDto()
        {
            Id = dbResult.Id,
            Name = dbResult.Name,
            DisplayName = dbResult.DisplayName,
            UrlCode = dbResult.UrlCode,
            IsShowOnHome = dbResult.IsShowOnHome,
            SortOrder = dbResult.SortOrder,
            SeoAlias = dbResult.SeoAlias,
            MetaTitle = dbResult.MetaTitle,
            MetaDescription = dbResult.MetaDescription,
            ImageUrl = dbResult.ImageUrl
        };
    }

    public async Task<CategoryResponseDto> GetByUrl(string url)
    {
        var dbResult = (await _uow.Repository<Category>().GetEntityWithSpec(x => x.UrlCode == url && x.Status == Status.Active, null)).FirstOrDefault();
        var mapping = MapListHelpers.MapObjectToString<CategoryResponseDto>(dbResult);
        return mapping;
    }

    public async Task<List<CategoryResponseDto>> ListCategory()
    {
        var result = (await _uow.Repository<Category>().GetEntityWithSpec(e => e.Status != Status.InActive)).ToList();

        var mapping = MapListHelpers.MapListObjectToString(result.ToList());
        var category = JsonConvert.DeserializeObject<List<CategoryResponseDto>>(mapping).OrderBy(x => x.SortOrder).ToList();

        return category;
    }

    public async Task<CategoryResponseDto> UpdateSingle(CategoryResquestDto request)
    {
        var dbResult = await _uow.Repository<Category>().GetByIdAsync(request.Id);

        if (dbResult == null)
        {
            return null;
        }

        dbResult.Name = request.Name;
        dbResult.DisplayName = request.DisplayName;
        dbResult.UrlCode = request.UrlCode;
        dbResult.IsShowOnHome = request.IsShowOnHome;
        dbResult.SortOrder = request.SortOrder;
        dbResult.SeoAlias = request.SeoAlias;
        dbResult.MetaTitle = request.MetaTitle;
        dbResult.MetaDescription = request.MetaDescription;
        dbResult.ImageUrl = request.ImageUrl;

        _uow.Repository<Category>().Update(dbResult);
        await _uow.Complete();
        return new CategoryResponseDto()
        {
            Id = dbResult.Id,
            Name = dbResult.Name,
            DisplayName = dbResult.DisplayName,
            UrlCode = dbResult.UrlCode,
            IsShowOnHome = dbResult.IsShowOnHome,
            SortOrder = dbResult.SortOrder,
            SeoAlias = dbResult.SeoAlias,
            MetaTitle = dbResult.MetaTitle,
            MetaDescription = dbResult.MetaDescription,
            ImageUrl = dbResult.ImageUrl
        };
    }
}
