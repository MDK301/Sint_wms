using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SChargeCodeStorage
{
    public int Id { get; set; }

    public string ChargeGroup { get; set; } = null!;

    public string? ChargeCost { get; set; }

    public string ChargeCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Explain { get; set; }

    public string? Unit { get; set; }

    public string? CompanyId { get; set; }

    public virtual ICollection<SAccountCostStorage> SAccountCostStorages { get; set; } = new List<SAccountCostStorage>();
}
