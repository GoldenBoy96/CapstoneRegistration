using System;
using System.Collections.Generic;

namespace DataAccessObject;

public partial class Topic
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime CreateDate { get; set; }

    public int SemesterId { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual Semester Semester { get; set; } = null!;

    public virtual ICollection<TopicOfLecturer> TopicOfLecturers { get; set; } = new List<TopicOfLecturer>();
}
