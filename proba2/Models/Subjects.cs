using System;
using System.Collections.Generic;

namespace proba2.Models;

public partial class Subjects
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public string SubjectCode { get; set; } = null!;

    public string SubjectDescription { get; set; } = null!;

    public int Semester { get; set; }

    public virtual ICollection<AssignedSubjects> AssignedSubjects { get; set; } = new List<AssignedSubjects>();

    public virtual ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();
}
