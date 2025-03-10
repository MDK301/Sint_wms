using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SStore
{
    public int Id { get; set; }

    public string StoreId { get; set; } = null!;

    public string? StoreName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? TaxNumber { get; set; }

    public byte[]? Logo { get; set; }

    public bool? PrinterRelo { get; set; }

    public string? CompanyId { get; set; }

    public virtual SLegalCompany? Company { get; set; }

    public virtual ICollection<ELot> ELots { get; set; } = new List<ELot>();

    public virtual ICollection<SLocation> SLocations { get; set; } = new List<SLocation>();
}
