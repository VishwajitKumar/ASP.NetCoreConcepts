using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIRepositoryPattern.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int Id);
        void UpdateEmployee(Employee employee);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int Id);
        string GetName();
    }
}
