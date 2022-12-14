using System;
using System.Collections.Generic;

namespace web_app.Models;

public partial class Employement
{
    public string EmployementId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Instructor> Instructor { get; } = new List<Instructor>();
}
