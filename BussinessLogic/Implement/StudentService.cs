using BussinessLogic.Abstraction;
using BussinessObject.Models;
using CapstoneRegistration.Repository.Repository;
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
        IStudentRepository _studentRepository;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _studentRepository = unitOfWork.StudentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Insert(student);
        }

        public List<Student> GetAllStudent()
        {
            return (List<Student>)_studentRepository.GetAll();
        }

        public Student? GetStudentById(int? id)
        {
            return _studentRepository.GetById(id);
        }

        public void RemoveStudent(Student student)
        {
            _studentRepository.Delete(student);
        }
    }
}
