using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EInventory
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? Lot { get; set; }

    public string? ProdId { get; set; }

    public int? QtyStart { get; set; }

    public decimal? NetWgtStart { get; set; }

    public int? QtyIn { get; set; }

    public decimal? NetWgtIn { get; set; }

    public int? QtyOut { get; set; }

    public decimal? NetWgtOut { get; set; }

    public int? QtyEnd { get; set; }

    public decimal? NetWgtEnd { get; set; }

    public int? PltStart { get; set; }

    public int? PltIn { get; set; }

    public int? PltOut { get; set; }

    public int? PltEnd { get; set; }

    public string? ChargeCode { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? ToatlAmount { get; set; }

    public string? Classification { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Account { get; set; }

    public string? StoreId { get; set; }

    public string? CompanyId { get; set; }

    public int? QtyBil { get; set; }

    public decimal? NetBil { get; set; }

    public int? PltBil { get; set; }

    public virtual ICollection<EInventoryCost> EInventoryCosts { get; set; } = new List<EInventoryCost>();

    public virtual SProduct? Prod { get; set; }
}
