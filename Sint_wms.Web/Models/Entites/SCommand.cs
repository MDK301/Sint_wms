using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SCommand
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? RoDo { get; set; }

    public string? Title { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CompanyId { get; set; }

    public virtual ICollection<EHistory> EHistories { get; set; } = new List<EHistory>();
}
