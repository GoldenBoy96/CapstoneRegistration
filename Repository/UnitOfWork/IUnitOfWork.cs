using DataAccessObject;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGroupRepo GroupRepo { get; }
        public ILecturerInGroupRepo LecturerInGroupRepo { get; }
        public ILecturerRepo LecturerRepo { get; }
        public ISemesterRepo SemesterRepo { get; }
        public IStudentInGroupRepo StudentInGroupRepo { get; }
        public IStudentInSemesterRepo StudentInSemesterRepo { get; }
        public IStudentRepo StudentRepo { get; }
        public ITopicOfLecturerRepo TopicOfLecturerRepo { get; }
        public ITopicRepo TopicRepo { get; }

    }
}
