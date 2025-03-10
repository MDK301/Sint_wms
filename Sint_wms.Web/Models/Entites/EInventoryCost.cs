using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EInventoryCost
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? Account { get; set; }

    public string? Lot { get; set; }

    public int? Qty { get; set; }

    public decimal? NetWgt { get; set; }

    public int? Pallet { get; set; }

    public string? ChargeCode { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? ToatlAmount { get; set; }

    public string? CompanyId { get; set; }

    public int? InventoryId { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Classification { get; set; }

    public string? Remark { get; set; }

    public virtual EInventory? Inventory { get; set; }
}
