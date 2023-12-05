using BussinessLogic.Abstraction;
using DataAccessObject;
using Repository.IRepository;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Implement
{
    public class StudentService :IStudentService
    {
        IStudentRepo _studentRepo;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _studentRepo = unitOfWork.StudentRepo;
        }

        public bool AddStudent(Student student)
        {
            return _studentRepo.Add(student);
        }

        public List<Student> GetAllStudent()
        {
            return (List<Student>)_studentRepo.GetAll();
        }

        public Student? GetStudentById(int? id)
        {
            return _studentRepo.GetById(id);
        }

        public bool RemoveStudent(Student student)
        {
            return _studentRepo.Remove(student);
        }
    }
}
