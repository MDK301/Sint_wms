using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SChargeCost
{
    public int Id { get; set; }

    public string ChargeId { get; set; } = null!;

    public string? ChargeName { get; set; }

    public string? Description { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public string? Cuscode { get; set; }

    public virtual ICollection<EChargeMi> EChargeMis { get; set; } = new List<EChargeMi>();
}
