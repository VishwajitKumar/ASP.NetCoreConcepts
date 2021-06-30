using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance is one of the primary pillar of OOps concept.
            //It provide the facility to inherite the properties, method to its derived class.
            //Hence code reusablity, less coding, less coding time, less error prone code are the advantage of Inheritance.
            //We define common properties, methods in base class and use in derived class. in derived class we define 
            //methods and properties only specific to that class. 

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Vishwajit";
            fullTimeEmployee.LastName = "Kumar";
            fullTimeEmployee.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            Employee employee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Ramesh";
            partTimeEmployee.LastName = "Kumar";
            employee.FirstName = "Ramesh from Base";
            employee.LastName = "Kumar from base";
            partTimeEmployee.PrintFullName();
           ((Employee)partTimeEmployee).PrintFullName();//will call base class PrintFullName
            employee.PrintFullName();//will call base class PrintFullName
            Console.ReadKey();
        }
    }
}
