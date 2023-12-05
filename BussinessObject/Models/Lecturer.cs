using System;
using System.Collections.Generic;

namespace DataAccessObject;

public partial class Lecturer
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Status { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<LecturerInGroup> LecturerInGroupInMainLecturerNavigations { get; set; } = new List<LecturerInGroup>();

    public virtual ICollection<LecturerInGroup> LecturerInGroupLecturers { get; set; } = new List<LecturerInGroup>();

    public virtual ICollection<TopicOfLecturer> TopicOfLecturers { get; set; } = new List<TopicOfLecturer>();
}
