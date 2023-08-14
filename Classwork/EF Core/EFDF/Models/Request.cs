using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Request
{
    public int Reqid { get; set; }

    public int? Donorid { get; set; }

    public string Request1 { get; set; } = null!;

    public DateTime Tym { get; set; }

    public virtual Donor? Donor { get; set; }
}
