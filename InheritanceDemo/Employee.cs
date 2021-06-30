using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Employee()
        {
            Console.WriteLine("Base class constructor called first");
        }
        public void PrintFullName()
        {
            Console.WriteLine($"{ FirstName} {LastName}- Base class");
        }
    }
}
