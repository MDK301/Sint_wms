using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SLegalCompany
{
    public int Id { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? ShostName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? TaxNumber { get; set; }

    public byte[]? Logo { get; set; }

    public virtual ICollection<SStore> SStores { get; set; } = new List<SStore>();
}
