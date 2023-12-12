using CapstoneRegistration.Repository.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IGroupRepository groupRepository, ILecturerRepository lecturerRepository, ISemesterRepository semesterRepository, IStudentRepository studentRepository, ITopicRepository topicRepository)
        {
            GroupRepository = groupRepository;
            LecturerRepository = lecturerRepository;
            SemesterRepository = semesterRepository;
            StudentRepository = studentRepository;
            TopicRepository = topicRepository;
        }

        public IGroupRepository GroupRepository { get; }
        public ILecturerRepository LecturerRepository { get; }
        public ISemesterRepository SemesterRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public ITopicRepository TopicRepository { get; }



        
    }
}
