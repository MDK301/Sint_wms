using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EOrder
{
    public int Id { get; set; }

    public string DateId { get; set; } = null!;

    public string DoNumber { get; set; } = null!;

    public string Lot { get; set; } = null!;

    public string? ProdId { get; set; }

    public int? Quantity { get; set; }

    public decimal? NetWgt { get; set; }

    public string? LotComment { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Cuscode { get; set; }

    public bool? Pull { get; set; }

    public DateTime? DoConfDate { get; set; }

    public string? Scanner { get; set; }

    public string? PalletId { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual EShipp Date { get; set; } = null!;
}
