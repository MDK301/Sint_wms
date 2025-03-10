using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SLocation
{
    public int Id { get; set; }

    public string PosId { get; set; } = null!;

    public string? Room { get; set; }

    public string? Line { get; set; }

    public string Local { get; set; } = null!;

    public string Floor { get; set; } = null!;

    public string Depth { get; set; } = null!;

    public bool? Lock { get; set; }

    public string StoreId { get; set; } = null!;

    public bool? Relay { get; set; }

    public bool? Hide { get; set; }

    public string? Remark { get; set; }

    public virtual SStore Store { get; set; } = null!;
}
