using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SUserPw
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Pasword { get; set; }

    public bool? Admin { get; set; }

    public bool? Manage { get; set; }

    public bool? StaffWarehouse { get; set; }

    public bool? StaffOffice { get; set; }

    public bool? Lock { get; set; }

    public string? Name { get; set; }

    public string? StoreId { get; set; }

    public string? Company { get; set; }
}
