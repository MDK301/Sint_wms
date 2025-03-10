using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EHistory
{
    public int Id { get; set; }

    public string? DateId { get; set; }

    public string? PalletId { get; set; }

    public string? ItemId { get; set; }

    public string? PosId { get; set; }

    public string? RoNumber { get; set; }

    public string? Title { get; set; }

    public string? Action { get; set; }

    public string? Lot { get; set; }

    public string? ProdId { get; set; }

    public int? Quantity { get; set; }

    public decimal? NetWgt { get; set; }

    public decimal? GrossWgt { get; set; }

    public int? QtyInven { get; set; }

    public string? Cuscode { get; set; }

    public string? LotComment { get; set; }

    public string? StoreId { get; set; }

    public DateOnly? Expiry { get; set; }

    public DateOnly? Mfg { get; set; }

    public string? LotRemark1 { get; set; }

    public string? LotRemark2 { get; set; }

    public string? LotRemark3 { get; set; }

    public string? Exception { get; set; }

    public DateTime? RoComfirmDate { get; set; }

    public string? DoNumber { get; set; }

    public int? OrderQty { get; set; }

    public int? ShipQty { get; set; }

    public DateTime? DoComfirmDate { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserName { get; set; }

    public bool? Inven { get; set; }

    public DateOnly? DateInven { get; set; }

    public virtual SCommand? Date { get; set; }
}
