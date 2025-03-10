using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class FFile
{
    public int Id { get; set; }

    public string? DateId { get; set; }

    public byte[]? Files { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreatedTime { get; set; }

    public bool? CurrentFile { get; set; }

    public string? StoreId { get; set; }
}
