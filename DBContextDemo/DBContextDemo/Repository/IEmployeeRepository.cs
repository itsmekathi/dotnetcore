using DBContextDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBContextDemo.Repository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();
        public Employee GetById(int employeeId);
        public Employee AddEmployee(Employee e);
        public Employee DeleteEmployee(int employeeId);

        public Employee UpdateEmployee(int id, Employee e);

    }
}
