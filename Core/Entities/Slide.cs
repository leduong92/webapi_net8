using Core.Enums;

namespace Core.Entities;

public class Slide : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
    public int SortOrder { get; set; }
}