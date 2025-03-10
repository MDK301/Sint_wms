using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SBot
{
    public int Id { get; set; }

    public string Keys { get; set; } = null!;

    public string? SerialNumber { get; set; }

    public string? Name { get; set; }

    public int? Activity { get; set; }

    public string? CreatedTime { get; set; }

    public string? Location { get; set; }
}
