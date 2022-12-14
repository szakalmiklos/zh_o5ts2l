using System;
using System.Collections.Generic;

namespace forms_app.Models;

public partial class Course
{
    public int CourseSk { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public virtual ICollection<Lesson> Lesson { get; } = new List<Lesson>();
}
