using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class ImageStorage
{
    public long Id { get; set; }

    public long ItemId { get; set; }

    public string ImageUrl { get; set; }

    public short? SortOrder { get; set; }
}
