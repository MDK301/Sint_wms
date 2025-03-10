using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SCustomer
{
    public int Id { get; set; }

    public string Cuscode { get; set; } = null!;

    public string? Customer { get; set; }

    public string? Fullname { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? TaxNumber { get; set; }

    public string? Email { get; set; }

    public string? StoreId { get; set; }

    public bool? Lock { get; set; }

    public string? ChargeCode { get; set; }

    public decimal? ChargeCost { get; set; }

    public bool? Pin { get; set; }

    public string? CompanyId { get; set; }

    public virtual ICollection<ERcpt> ERcpts { get; set; } = new List<ERcpt>();

    public virtual ICollection<EShipp> EShipps { get; set; } = new List<EShipp>();

    public virtual ICollection<SAccountCostStorage> SAccountCostStorages { get; set; } = new List<SAccountCostStorage>();

    public virtual ICollection<SProduct> SProducts { get; set; } = new List<SProduct>();
}
