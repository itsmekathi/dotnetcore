using DBContextDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBContextDemo.Repository
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAll();
        public Student GetById(int id);
    }
}
