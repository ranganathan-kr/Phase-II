using System;
using System.Collections.Generic;

namespace EFDF.Models;

public partial class Department
{
    public int Depno { get; set; }

    public string? Dname { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
