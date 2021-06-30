using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class FullTimeEmployee:Employee
    {
        public FullTimeEmployee()
        {
            Console.WriteLine("FullTimeEmployee constructor called");
        }
        public float YearlySalary { get; set; }
    }
}
