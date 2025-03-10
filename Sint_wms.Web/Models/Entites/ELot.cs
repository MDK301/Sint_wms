using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class ELot
{
    public int Id { get; set; }

    public string LotId { get; set; } = null!;

    public int? Unit { get; set; }

    public string? DateId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserId { get; set; }

    public DateOnly? Mfg { get; set; }

    public DateOnly? Exp { get; set; }

    public string StoreId { get; set; } = null!;

    public virtual ICollection<ERcptD> ERcptDs { get; set; } = new List<ERcptD>();

    public virtual SStore Store { get; set; } = null!;
}
