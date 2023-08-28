namespace Core.Entities;

public class Size : BaseEntity
{
    public string Name { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}