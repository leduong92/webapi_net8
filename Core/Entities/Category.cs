namespace Core.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string UrlCode { get; set; }
    public bool IsShowOnHome { get; set; }
    public int SortOrder { get; set; }
    public string SeoAlias { get; set; }
    public string MetaTitle { get; set; }
    public string MetaKeyword { get; set; }
    public string MetaDescription { get; set; }
    public string ImageUrl { get; set; }

}