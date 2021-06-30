using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIRepositoryPattern.Interfaces;

namespace WebAPIRepositoryPattern.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>() {
            new Employee(){Id=1,Name="Rahul"},
            new Employee(){Id=2,Name="Raj"},
            new Employee(){Id=3,Name="Ajay"},
            new Employee(){Id=4,Name="Vijay"}
            };
        }

        public Employee GetEmployeeById(int Id)
        {
            List<Employee> employees = new List<Employee>() {
            new Employee(){Id=1,Name="Rahul"},
            new Employee(){Id=2,Name="Raj"},
            new Employee(){Id=3,Name="Ajay"},
            new Employee(){Id=4,Name="Vijay"}
            };
            return employees.SingleOrDefault(x => x.Id.Equals(Id));
        }

        public void UpdateEmployee(Employee employee)
        {
            List<Employee> employees = new List<Employee>() {
            new Employee(){Id=1,Name="Rahul"},
            new Employee(){Id=2,Name="Raj"},
            new Employee(){Id=3,Name="Ajay"},
            new Employee(){Id=4,Name="Vijay"}
            };

            employee = employees.SingleOrDefault(x => x.Id.Equals(employee.Id));
            employee.Name = "Vishwajit";
        }
        public string GetName()
        {
            return "From Employee Repository";
        }
    }
}
