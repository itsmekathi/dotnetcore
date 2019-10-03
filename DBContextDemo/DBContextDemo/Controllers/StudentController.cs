using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBContextDemo.Models;
using DBContextDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBContextDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return studentRepository.GetAll();
        }
    }
}