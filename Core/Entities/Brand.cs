﻿using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Brand
{
    public int Id { get; set; }

    public string BrandName { get; set; }

    public string UrlCode { get; set; }

    public short? SortOrder { get; set; }

    public string Description { get; set; }

    public string MetaKeyword { get; set; }

    public string MetaDescription { get; set; }

    public string DisplayName { get; set; }

    public string ImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsLogo { get; set; }

    public bool? IsDisplayName { get; set; }

    public bool? IsDescription { get; set; }

    public bool? IsImage { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Collection> Collections { get; set; } = new List<Collection>();
}
