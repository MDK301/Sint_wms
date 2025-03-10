using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EChargeMi
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? Cuscode { get; set; }

    public string? DoRo { get; set; }

    public string? ChargeId { get; set; }

    public decimal? Qty { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? DateId { get; set; }

    public string? Users { get; set; }

    public string? StoreId { get; set; }

    public virtual SChargeCost? Charge { get; set; }
}
