using System;
using System.Collections.Generic;

namespace proba2.Models;

public partial class Enrollments
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public virtual Students Student { get; set; } = null!;

    public virtual Subjects Subject { get; set; } = null!;
}
