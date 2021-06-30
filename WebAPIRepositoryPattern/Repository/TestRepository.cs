using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIRepositoryPattern.Interfaces;

namespace WebAPIRepositoryPattern.Repository
{
    public class TestRepository : IEmployeeRepository
    {
        void IEmployeeRepository.AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.DeleteEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        List<Employee> IEmployeeRepository.GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeRepository.GetEmployeeById(int Id)
        {
            throw new NotImplementedException();
        }

        string IEmployeeRepository.GetName()
        {
            return "From test Repository";
        }

        void IEmployeeRepository.UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
