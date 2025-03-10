using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SAccountCostStorage
{
    public int Id { get; set; }

    public string? Account { get; set; }

    public string? ChargeCode { get; set; }

    public decimal? UnitPrice { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserId { get; set; }

    public string? Classification { get; set; }

    public virtual SCustomer? AccountNavigation { get; set; }

    public virtual SChargeCodeStorage? ChargeCodeNavigation { get; set; }
}
