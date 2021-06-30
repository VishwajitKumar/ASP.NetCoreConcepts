using System;

namespace PolymorphismDemo
{
    class Employee
    {
        //Polymorphism is, base class reference pointing to derived class instance, calling overridden method of derived class.
        //In below example, employee class reference variable pointing to fulltimeemployee class instance, and calling derived class
        //method printfullname. Because in base class printfullname method is marked as virtual.
        //VIRTUAL keyword is mandatory to be overridden.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual void PrintFullName()
        {
            Console.WriteLine($"{ FirstName} {LastName}- Base class");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{ FirstName} {LastName}- derived class");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee =new FullTimeEmployee();
            employee.FirstName = "Vishwajit";
            employee.LastName = "Kumar";
            employee.PrintFullName();
            Console.ReadKey();
        }
    }
}
