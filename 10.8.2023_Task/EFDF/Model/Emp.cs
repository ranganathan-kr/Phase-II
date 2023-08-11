using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Emp
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Addr { get; set; }

    public int? Depno { get; set; }

    public virtual Department? DepnoNavigation { get; set; }
}
