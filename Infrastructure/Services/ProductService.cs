using System.Net.Http.Headers;
using Core.Constants;
using Core.DTO.RequestDto;
using Core.Entities;
using Core.Enums;
using Core.Interfaces;
using Core.Model;
using Infrastructure.HelperService;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Infrastructure.Services;
public class ProductService : IProductService
{
    private readonly IUnitOfWork _uow;
    private readonly IStorageService _storageService;
    public ProductService(IUnitOfWork uow, IStorageService storageService)
    {
        _uow = uow;
        _storageService = storageService;
    }

    public async Task<List<ProductResponseDto>> ListProductByCategory(Guid categoryId)
    {
        var products = (await _uow.Repository<Product>().GetEntityWithSpec(x => x.CategoryId == categoryId && x.Status == Status.Active, null, "Category")).ToList();

        if (products == null)
        {
            return null;
        }

        var mapping = MapListHelpers.MapListObjectToString(products.ToList());
        var lstResults = JsonConvert.DeserializeObject<List<ProductResponseDto>>(mapping).OrderBy(x => x.Sku).ToList();
        return lstResults;
    }

    public async Task<PagedResult<ProductResponseDto>> ListProducts(PagingWithTimeRequestDTO request)
    {

        string searchKey = !string.IsNullOrEmpty(request.SearchKey) ? request.SearchKey.ToUpper() : string.Empty;
        var paging = new PagedResult<Product>();
        paging = await _uow.Repository<Product>().GetWithPaging(request.PageIndex, request.PageSize, x => x.Status == Status.Active, null, "Category,ProductImages");

        var mapping = MapListHelpers.MapListObjectToString(paging.Results.ToList());
        var lstResults = JsonConvert.DeserializeObject<List<ProductResponseDto>>(mapping).OrderBy(x => x.DisplayName).ToList();
        var result = new PagedResult<ProductResponseDto>
        {
            PageIndex = paging.PageIndex,
            PageSize = paging.PageSize,
            NumberOfPage = paging.NumberOfPage,
            TotalCount = paging.TotalCount,
            Results = lstResults
        };
        return result;
    }
    public async Task<ProductResponseDto> AddSingle(ProductRequestDto request)
    {
        var product = new Product()
        {
            Name = request.Name,
            Sku = request.Sku,
            UrlCode = request.UrlCode,
            DisplayName = request.DisplayName,
            Description = request.Description,
            SeoAlias = request.SeoAlias,
            MetaTitle = request.MetaTitle,
            MetaKeyword = request.MetaKeyword,
            MetaDescription = request.MetaDescription,
            Price = request.Price,
            OriginalPrice = request.OriginalPrice,
            Discount = request.Discount,
            IsFeatured = request.IsFeatured,
            IsNew = request.IsNew,
            IsBestSeller = request.IsBestSeller,
            CategoryId = request.CategoryId
        };

        var images = new List<ProductImage>();

        if (request.MainImage != null)
        {
            product.ProductImages = new List<ProductImage>()
            {
                new ProductImage()
                {
                    Caption = "Main image",
                    FileSize = request.MainImage.Length,
                    Url = await this.SaveFile(request.MainImage),
                    IsDefault = true,
                    SortOrder = 1
                }
            };
        }

        if (request.ThumbnailImage != null)
        {
            var idx = 2;
            foreach (var item in request.ThumbnailImage)
            {
                var img = new ProductImage()
                {
                    Caption = "Thumbnail image",
                    FileSize = item.Length,
                    Url = await this.SaveFile(item),
                    IsDefault = false,
                    SortOrder = idx
                };
                images.Add(img);
                idx++;
            }
            product.ProductImages.AddRange(images);
        }

        _uow.Repository<ProductImage>().InsertList(images);
        _uow.Repository<Product>().Insert(product);
        await _uow.Complete();

        var rsp = await this.GetByID(product.Id);
        if (rsp == null)
            return null;

        return rsp;
    }

    public async Task<int> DeleteSingle(ProductRequestDto request)
    {
        var dbResult = await _uow.Repository<Product>().GetByIdAsync(request.Id);
        _uow.Repository<Product>().Delete(dbResult);
        return await _uow.Complete();
    }

    public async Task<ProductResponseDto> GetByID(Guid id)
    {
        var dbResult = (await _uow.Repository<Product>().GetEntityWithSpec(x => x.Id == id && x.Status == Status.Active, null, "Category,ProductImages")).FirstOrDefault();
        var mapping = MapListHelpers.MapObjectToString<ProductResponseDto>(dbResult);
        return mapping;
    }
    public async Task<ProductResponseDto> UpdateSingle(ProductRequestDto request)
    {
        var dbResult = await _uow.Repository<Product>().GetByIdAsync(request.Id);

        if (dbResult == null)
            return null;

        dbResult.Name = string.IsNullOrEmpty(request.Name) ? dbResult.Name : request.Name;
        dbResult.Sku = string.IsNullOrEmpty(request.Sku) ? dbResult.Sku : request.Sku;
        dbResult.UrlCode = string.IsNullOrEmpty(request.UrlCode) ? dbResult.UrlCode : request.UrlCode;
        dbResult.DisplayName = string.IsNullOrEmpty(request.DisplayName) ? dbResult.DisplayName : request.DisplayName;
        dbResult.Description = string.IsNullOrEmpty(request.Description) ? dbResult.Description : request.Description;
        dbResult.SeoAlias = string.IsNullOrEmpty(request.SeoAlias) ? dbResult.SeoAlias : request.SeoAlias;
        dbResult.MetaTitle = string.IsNullOrEmpty(request.MetaTitle) ? dbResult.MetaTitle : request.MetaTitle;
        dbResult.MetaKeyword = string.IsNullOrEmpty(request.MetaKeyword) ? dbResult.MetaKeyword : request.MetaKeyword;
        dbResult.MetaDescription = string.IsNullOrEmpty(request.MetaDescription) ? dbResult.MetaDescription : request.MetaDescription;
        dbResult.Price = request.Price == 0 ? dbResult.Price : request.Price;
        dbResult.OriginalPrice = request.OriginalPrice == 0 ? dbResult.OriginalPrice : request.OriginalPrice;
        dbResult.Discount = request.Discount == 0 ? dbResult.Discount : request.Discount;
        dbResult.IsFeatured = request.IsFeatured;
        dbResult.IsNew = request.IsNew;
        dbResult.IsBestSeller = request.IsBestSeller;

        if (request.MainImage != null)
        {
            var imagesDelete = (await _uow.Repository<ProductImage>().GetEntityWithSpec(x => x.ProductId == request.Id)).ToList();
            _uow.Repository<ProductImage>().Delete(x => x.ProductId == request.Id && x.IsDefault == true);
            var img = new ProductImage()
            {
                Caption = "Main image",
                FileSize = request.MainImage.Length,
                Url = await this.SaveFile(request.MainImage),
                ProductId = request.Id,
                IsDefault = true,
                SortOrder = 1
            };
            _uow.Repository<ProductImage>().Insert(img);
        }
        var images = new List<ProductImage>();
        if (request.ThumbnailImage != null)
        {
            var idx = 2;
            _uow.Repository<ProductImage>().Delete(x => x.ProductId == request.Id && x.IsDefault != true);
            foreach (var item in request.ThumbnailImage)
            {
                var img = new ProductImage()
                {
                    Caption = "Thumbnail image",
                    FileSize = item.Length,
                    Url = await this.SaveFile(item),
                    ProductId = request.Id,
                    IsDefault = false,
                    SortOrder = idx
                };
                images.Add(img);
                idx++;
            }
            _uow.Repository<ProductImage>().InsertList(images);
        }

        _uow.Repository<Product>().Update(dbResult);
        await _uow.Complete();

        var rsp = await this.GetByID(dbResult.Id);
        if (rsp == null)
            return null;

        return rsp;
    }

    private async Task<string> SaveFile(IFormFile file)
    {
        var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
        await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
        return "/" + SystemConstants.IMAGE_CONTENT_FOLDER_NAME + "/" + fileName;
    }

    public async Task<List<ProductResponseDto>> ListFeatureds()
    {
        var products = (await _uow.Repository<Product>().GetEntityWithSpec(x => x.IsFeatured == true && x.Status == Status.Active, null, "Category,ProductImages")).ToList();
        if (products == null)
            return null;
        var mapping = MapListHelpers.MapListObjectToString(products.ToList());
        var lstResults = JsonConvert.DeserializeObject<List<ProductResponseDto>>(mapping).OrderBy(x => x.Sku).ToList();
        return lstResults;
    }

    public async Task<List<ProductResponseDto>> ListNewProducts()
    {
        var products = (await _uow.Repository<Product>().GetEntityWithSpec(x => x.IsNew == true && x.Status == Status.Active, null, "Category,ProductImages")).ToList();
        if (products == null)
            return null;
        var mapping = MapListHelpers.MapListObjectToString(products.ToList());
        var lstResults = JsonConvert.DeserializeObject<List<ProductResponseDto>>(mapping).OrderBy(x => x.Sku).ToList();
        return lstResults;
    }
}


