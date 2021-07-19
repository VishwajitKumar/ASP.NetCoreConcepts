using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee constructor called");
        }
        public double HourlyRate { get; set; }

        //PrintFullName is implemented in Employee class and in derived class PartTimeEmployee also.
        /// <summary>
        /// /Here derived class is hiding the inherited member PrintFullName of base class.
        /// so after running the application derived class method will be called.
        /// If it is intended then We need to use new keyword in method after access modifier
        /// </summary>
        public new void PrintFullName()
        {
            //PrintFullName();//It will call base class printfullname method.
            Console.WriteLine($"{ FirstName} {LastName}- Derived class hiding base class Printfullname method");
        }
    }
}
