using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class EShipp
{
    public int Id { get; set; }

    public string DateId { get; set; } = null!;

    public DateTime? TruckIn { get; set; }

    public string? Account { get; set; }

    public string? Cuscode { get; set; }

    public string? Truck { get; set; }

    public string? Status { get; set; }

    public string? DoNumber { get; set; }

    public int? Quantity { get; set; }

    public decimal? NetWgt { get; set; }

    public int? Pallet { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? FinishTime { get; set; }

    public int? Door { get; set; }

    public string? Comment { get; set; }

    public string? Users { get; set; }

    public decimal? TotalTime { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Reference { get; set; }

    public DateOnly? DateOrder { get; set; }

    public DateOnly? DateConfirm { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? StoreId { get; set; }

    public string? CompanyId { get; set; }

    public string? Handling { get; set; }

    public virtual SCustomer? CuscodeNavigation { get; set; }

    public virtual ICollection<EHangdingCost> EHangdingCosts { get; set; } = new List<EHangdingCost>();

    public virtual ICollection<EOrderLoca> EOrderLocas { get; set; } = new List<EOrderLoca>();

    public virtual ICollection<EOrder> EOrders { get; set; } = new List<EOrder>();

    public virtual ICollection<EShippD> EShippDs { get; set; } = new List<EShippD>();
}
