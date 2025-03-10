using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EWeght
{
    public int Id { get; set; }

    public string? DateId { get; set; }

    public string? PalletId { get; set; }

    public string RoDo { get; set; } = null!;

    public string? Cuscode { get; set; }

    public string? Code { get; set; }

    public int? Quantity { get; set; }

    public decimal? Kg { get; set; }

    public decimal? Lb { get; set; }

    public string? Unit { get; set; }

    public int? Trim { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Lot { get; set; }

    public DateOnly? Exp { get; set; }

    public DateOnly? Mfg { get; set; }

    public bool? Stocking { get; set; }

    public string? ProdId { get; set; }

    public string? Reference { get; set; }

    public decimal? NetRef { get; set; }

    public string? Mnx { get; set; }

    public bool? Action { get; set; }

    public string? CompanyId { get; set; }
}
