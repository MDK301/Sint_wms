using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }
}
