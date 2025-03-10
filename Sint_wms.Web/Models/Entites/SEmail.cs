using System;
using System.Collections.Generic;

namespace Sint_wms.Web.Models.Entites;

public partial class SEmail
{
    public int Id { get; set; }

    public string? GrReport { get; set; }

    public string? Email { get; set; }

    public string? CompanyId { get; set; }
}
