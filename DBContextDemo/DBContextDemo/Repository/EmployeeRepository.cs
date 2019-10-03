using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBContextDemo.Context;
using DBContextDemo.Models;

namespace DBContextDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

       
        public Employee AddEmployee(Employee e)
        {
            applicationDbContext.Add(e);
            applicationDbContext.SaveChanges();
            return e;
        }

        public IEnumerable<Employee> GetAll()
        {
            var response = applicationDbContext.Employess;
            return response;
        }

        public Employee GetById(int employeeId)
        {
            var response = applicationDbContext.Employess.Find(employeeId);
            return response;
        }

        public Employee DeleteEmployee(int employeeId)
        {
            var employee = applicationDbContext.Employess.Find(employeeId);
            applicationDbContext.Remove(employee);
            applicationDbContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(int id, Employee e)
        {
            throw new NotImplementedException();

        }
    }
}
