using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Abstraction
{
    public interface IStudentService
    {
        bool AddStudent(Student student);
        List<Student> GetAllStudent();
        Student? GetStudentById(int? id);
        bool RemoveStudent(Student student);
    }
}
