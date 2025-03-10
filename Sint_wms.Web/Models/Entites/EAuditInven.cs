using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EAuditInven
{
    public int Id { get; set; }

    public string PosId { get; set; } = null!;

    public string Lot { get; set; } = null!;

    public string? ProdId { get; set; }

    public decimal? QtyInven { get; set; }

    public decimal? QtyCheck { get; set; }

    public decimal? DiffNumber { get; set; }

    public string? Remark { get; set; }

    public DateOnly? Mfg { get; set; }

    public DateOnly? Expiry { get; set; }

    public string? Status { get; set; }

    public string Account { get; set; } = null!;

    public string? StoreId { get; set; }

    public string DateId { get; set; } = null!;

    public string PalletId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public bool? CheckIn { get; set; }

    public string? UserId { get; set; }

    public DateTime? CheckDate { get; set; }

    public DateTime? CreatedTime { get; set; }
}
