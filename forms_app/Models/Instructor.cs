using System;
using System.Collections.Generic;

namespace forms_app.Models;

public partial class Instructor
{
    public int InstructorSk { get; set; }

    public string? Salutation { get; set; }

    public string Name { get; set; } = null!;

    public byte? StatusFk { get; set; }

    public string? EmployementFk { get; set; }

    public virtual Employement? EmployementFkNavigation { get; set; }

    public virtual ICollection<Lesson> Lesson { get; } = new List<Lesson>();

    public virtual Status? StatusFkNavigation { get; set; }
}
