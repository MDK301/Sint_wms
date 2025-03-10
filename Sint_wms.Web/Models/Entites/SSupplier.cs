using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SSupplier
{
    public int Id { get; set; }

    public string SuppId { get; set; } = null!;

    public string? Supplier { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? TaxNumber { get; set; }

    public string? Email { get; set; }

    public bool? Lock { get; set; }

    public string? StoreId { get; set; }
}
