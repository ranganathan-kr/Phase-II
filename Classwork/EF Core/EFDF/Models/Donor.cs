using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Donor
{
    public int Donorid { get; set; }

    public string Name { get; set; } = null!;

    public string Num { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Gender { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Alcoholic { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
