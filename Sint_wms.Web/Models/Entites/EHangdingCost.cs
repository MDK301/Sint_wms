using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EHangdingCost
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? Account { get; set; }

    public string? DateId { get; set; }

    public decimal? NetWgt { get; set; }

    public string? ChargeCode { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? ToatlAmount { get; set; }

    public string? CompanyId { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Classification { get; set; }

    public string? Remark { get; set; }

    public string? RoDo { get; set; }

    public virtual EShipp? Date1 { get; set; }

    public virtual ERcpt? DateNavigation { get; set; }
}
