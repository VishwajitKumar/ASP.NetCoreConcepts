using LSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }
        protected Employee()
        {

        }
        protected Employee(int id, string name, string employeeType)
        {
            this.Id = id;
            this.Name = name;
            this.EmployeeType = employeeType;
        }

        public abstract double CalculateBonus(double salary);
        public abstract double GetMinimumSalary(double salary);
    }

    


        public class PermanentEmp : Employee
    {
        public PermanentEmp()
        {

        }
        public PermanentEmp(int id, string name, string employeeType)
        {
            this.Id = id;
            this.Name = name;
            this.EmployeeType = employeeType;
        }
        public override  double GetMinimumSalary(double salary)
        {
            return salary;
        }
        public override double CalculateBonus(double salary)
        {
            return salary * 10;
        }
    }
    public class ContractEmp : Employee
    {
        public ContractEmp()
        {

        }
        public ContractEmp(int id, string name, string employeeType)
        {
            this.Id = id;
            this.Name = name;
            this.EmployeeType = employeeType;
        }
        public override double CalculateBonus(double salary)
        {
            return salary * 5;
        }
        public override double GetMinimumSalary(double salary)
        {
            return salary;
        }
    }
    public class TemporaryEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TemporaryEmployee()
        {

        }
        public TemporaryEmployee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public double GetMinimumSalary(double salary)
        {
            return salary;
        }
    }
}
