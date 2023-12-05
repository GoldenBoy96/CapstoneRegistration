﻿using DataAccessObject;
using Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IStudentRepo : IGenericRepo<Student>
    {
    }
}