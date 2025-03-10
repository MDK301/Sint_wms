using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SPrinter
{
    public int Id { get; set; }

    public string? IdPrint { get; set; }

    public string? NamePrint { get; set; }

    public string? Description { get; set; }

    public bool? SetAuto { get; set; }

    public string? StoreId { get; set; }
}
