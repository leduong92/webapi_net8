namespace Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Sku { get; set; }
    public string UrlCode { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string SeoAlias { get; set; }
    public string MetaTitle { get; set; }
    public string MetaKeyword { get; set; }
    public string MetaDescription { get; set; }
    public double Price { get; set; }
    public double OriginalPrice { get; set; }
    public double Discount { get; set; }
    public bool? IsFeatured { get; set; }
    public bool? IsNew { get; set; }
    public bool? IsBestSeller { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
}