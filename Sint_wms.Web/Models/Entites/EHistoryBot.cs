using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EHistoryBot
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Bot { get; set; }

    public string? Action { get; set; }

    public string? Remark { get; set; }

    public string? Error { get; set; }

    public string? StoreId { get; set; }
}
