using System;
using System.Collections.Generic;

namespace proba2.Models;

public partial class AssignedSubjects
{
    public int AssignId { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public virtual Subjects Subject { get; set; } = null!;

    public virtual Teachers Teacher { get; set; } = null!;
}
