using DataAccessObject;
using Repository.GenericRepository;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class StudentInGroupRepo : GenericRepo<StudentInGroup>, IStudentInGroupRepo
    {
        public StudentInGroupRepo(CapstoneRigistrationContext context) : base(context)
        {
        }
    }
}
