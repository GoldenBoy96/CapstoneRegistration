using DataAccessObject;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(IGroupRepo groupRepo, ILecturerInGroupRepo lecturerInGroupRepo, ILecturerRepo lecturerRepo, ISemesterRepo semesterRepo, IStudentInGroupRepo studentInGroupRepo, IStudentInSemesterRepo studentInSemesterRepo, IStudentRepo studentRepo, ITopicOfLecturerRepo topicOfLecturerRepo, ITopicRepo topicRepo)
        {
            GroupRepo = groupRepo;
            LecturerInGroupRepo = lecturerInGroupRepo;
            LecturerRepo = lecturerRepo;
            SemesterRepo = semesterRepo;
            StudentInGroupRepo = studentInGroupRepo;
            StudentInSemesterRepo = studentInSemesterRepo;
            StudentRepo = studentRepo;
            TopicOfLecturerRepo = topicOfLecturerRepo;
            TopicRepo = topicRepo;
        }

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
