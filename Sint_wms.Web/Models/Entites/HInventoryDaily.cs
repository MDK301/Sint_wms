using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class HInventoryDaily
{
    public int Id { get; set; }

    public string DateId { get; set; } = null!;

    public string? PalletId { get; set; }

    public string? ItemId { get; set; }

    public string Account { get; set; } = null!;

    public string PosId { get; set; } = null!;

    public string? RoNumber { get; set; }

    public string? Lot { get; set; }

    public string? ProdId { get; set; }

    public int? Quantity { get; set; }

    public decimal? NetWgt { get; set; }

    public decimal? GrossWgt { get; set; }

    public int? QtyInven { get; set; }

    public decimal? NetInven { get; set; }

    public int? QtyOrder { get; set; }

    public int? Hold { get; set; }

    public bool? Stocking { get; set; }

    public string? LotComment { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateOnly? Mfg { get; set; }

    public DateOnly? Expiry { get; set; }

    public bool? CheckScan { get; set; }

    public string? Scanner { get; set; }

    public bool? Print { get; set; }

    public DateTime? LastMovement { get; set; }

    public string? LotRemark1 { get; set; }

    public string? LotRemark2 { get; set; }

    public string? LotRemark3 { get; set; }

    public int? WeightId { get; set; }

    public decimal? NetAver { get; set; }

    public string? UserName { get; set; }

    public string? StoreId { get; set; }

    public string? CompanyId { get; set; }

    public DateOnly? DateReport { get; set; }
}
