using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public abstract class Employee
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
        //Move this method implementation to derived class and make this as abstract method
        //public double CalculateBonus(double salary)
        //{

        //    if (EmployeeType == "Permanent")
        //        salary= salary + (salary * 10);
        //    else if (EmployeeType == "Contract")
        //        salary= salary + (salary * 5);
        //    return salary;
        //}

        public abstract double CalculateBonus(double salary);

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
    }
}
