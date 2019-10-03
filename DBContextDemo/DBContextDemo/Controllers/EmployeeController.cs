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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeRepository.GetAll();
        }

        [HttpPost]
        public Employee AddEmployee(Employee e)
        {
            return employeeRepository.AddEmployee(e);
        }

        [HttpDelete]
        public Employee DeleteEmployee(int employeeId)
        {
            return employeeRepository.DeleteEmployee(employeeId);
        }
    }
}