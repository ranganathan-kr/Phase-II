using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Report
{
    public int Repid { get; set; }

    public int Donorid { get; set; }

    public string Report1 { get; set; } = null!;

    public DateTime Tym { get; set; }

    public virtual Donor Donor { get; set; } = null!;
}
