using CapstoneRegistration.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IGroupRepository GroupRepository { get; }
        public ILecturerRepository LecturerRepository { get; }
        public ISemesterRepository SemesterRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public ITopicRepository TopicRepository { get; }

    }
}
