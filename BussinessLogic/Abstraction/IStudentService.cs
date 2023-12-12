using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Abstraction
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> GetAllStudent();
        Student? GetStudentById(int? id);
        void RemoveStudent(Student student);
    }
}
