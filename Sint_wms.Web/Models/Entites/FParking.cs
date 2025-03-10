using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class FParking
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? CodeCard { get; set; }

    public string? CarNumber { get; set; }

    public byte[]? FileImage { get; set; }

    public string? UserId { get; set; }

    public DateTime? TimeIn { get; set; }

    public DateTime? TimeOut { get; set; }

    public bool? CurrentFile { get; set; }

    public string? Area { get; set; }
}
