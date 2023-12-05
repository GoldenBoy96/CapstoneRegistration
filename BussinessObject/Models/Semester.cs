using System;
using System.Collections.Generic;

namespace DataAccessObject;

public partial class Semester
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Year { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<StudentInSemester> StudentInSemesters { get; set; } = new List<StudentInSemester>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();
}
