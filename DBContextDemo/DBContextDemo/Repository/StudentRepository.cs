using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBContextDemo.Context;
using DBContextDemo.Models;

namespace DBContextDemo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StudentRepository(ApplicationDbContext applicationDbContext )
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Student> GetAll()
        {
            var response =  applicationDbContext.Students.ToList();
            return response;
        }

        public Student GetById(int id)
        {
            var response =  applicationDbContext.Students.FirstOrDefault(s => s.Id == id);
            return response;
        }
    }
}
