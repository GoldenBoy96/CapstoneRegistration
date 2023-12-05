using System;
using System.Collections.Generic;

namespace DataAccessObject;

public partial class Student
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Avatar { get; set; }

    public DateTime DateOfBirth { get; set; }

    public bool Gender { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<StudentInGroup> StudentInGroups { get; set; } = new List<StudentInGroup>();

    public virtual ICollection<StudentInSemester> StudentInSemesters { get; set; } = new List<StudentInSemester>();
}
