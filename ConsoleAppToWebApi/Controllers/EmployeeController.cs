using ConsoleAppToWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram" },
            new Employee() { Id = 2, Name = "Shyam" },
            new Employee() { Id = 3, Name = "Mohan" },
            new Employee() { Id = 4, Name = "Gopal" },
            };
            return employees;
        }
        [Route("{id}")]
        public IActionResult GetEmployeeById(int Id)
        {
            if (Id == 0)
                return NotFound();
            else
            {
                List<Employee> employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram" },
            new Employee() { Id = 2, Name = "Shyam" },
            new Employee() { Id = 3, Name = "Mohan" },
            new Employee() { Id = 4, Name = "Gopal" },
            };
                var emp = employees.FirstOrDefault(x => x.Id.Equals(Id));
                return Ok(emp);
            }
        }
        [Route("{id}/basic")]
        public ActionResult<Employee> GetEmployeeBasicById(int Id)
        {
            if (Id == 0)
                return NotFound();
            else
            {
                List<Employee> employees = new List<Employee>() {
                new Employee() { Id = 1, Name = "Ram" },
            new Employee() { Id = 2, Name = "Shyam" },
            new Employee() { Id = 3, Name = "Mohan" },
            new Employee() { Id = 4, Name = "Gopal" },
            };
                return employees.FirstOrDefault(x => x.Id.Equals(Id));

            }
        }
    }
}
