using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SProduct
{
    public int Id { get; set; }

    public string ProdId { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string? ProductName { get; set; }

    public decimal? NetWgt { get; set; }

    public decimal? GrossWgt { get; set; }

    public string? Code { get; set; }

    public bool? Lock { get; set; }

    public string? Unit { get; set; }

    public int? Carton { get; set; }

    public string? Category { get; set; }

    public string? StoreId { get; set; }

    public string? CompanyId { get; set; }

    public string? QrCode { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? Classification { get; set; }

    public virtual SCustomer AccountNavigation { get; set; } = null!;

    public virtual ICollection<EInventory> EInventories { get; set; } = new List<EInventory>();
}
