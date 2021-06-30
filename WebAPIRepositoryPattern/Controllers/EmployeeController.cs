using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIRepositoryPattern.Interfaces;

namespace WebAPIRepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return _employee.GetAllEmployees();
        }

        [HttpGet]
        [Route("{Id}")]
        public Employee GetEmployeeById(int Id)
        {
            return _employee.GetEmployeeById(Id);
        }

        [HttpPut]
        public Employee UpdatedEmployee(Employee employee)
        {
            employee.Id = 3;
            _employee.UpdateEmployee(employee);
            return employee;
        }

        [HttpGet]
        public string GetName()
        {
          return  _employee.GetName();
             
        }
    }
}
