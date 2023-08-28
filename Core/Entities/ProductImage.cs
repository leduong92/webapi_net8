namespace Core.Entities;

public class ProductImage : BaseEntity
{
    public string Url { get; set; }
    public string Caption { get; set; }
    public bool IsDefault { get; set; }
    public int SortOrder { get; set; }
    public long FileSize { get; set; }
    public Guid? ProductId { get; set; }
    // public Product Product { get; set; }
}