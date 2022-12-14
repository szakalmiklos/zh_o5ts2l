using System;
using System.Collections.Generic;

namespace forms_app.Models;

public partial class Day
{
    public byte DayId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lesson { get; } = new List<Lesson>();
}
