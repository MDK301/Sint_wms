using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SEmployee
{
    public int Id { get; set; }

    public string EmpId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? StoreId { get; set; }
}
