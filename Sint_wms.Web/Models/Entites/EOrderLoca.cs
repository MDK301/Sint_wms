using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EOrderLoca
{
    public int Id { get; set; }

    public string DateId { get; set; } = null!;

    public string PalletId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string PosId { get; set; } = null!;

    public string? DoNumber { get; set; }

    public string? Lot { get; set; }

    public string? ProdId { get; set; }

    public int? Quantity { get; set; }

    public decimal? NetWgt { get; set; }

    public decimal? GrossWgt { get; set; }

    public bool? Pull { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Cuscode { get; set; }

    public string? StorId { get; set; }

    public string? Action { get; set; }

    public string? Scanner { get; set; }

    public DateOnly? DateConfirm { get; set; }

    public string? PullId { get; set; }

    public virtual EShipp Date { get; set; } = null!;
}
