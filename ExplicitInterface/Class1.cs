using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterface
{
    class Class1:Interface1,Interface2
    {
        //Explicit interface implementation
        void Interface1.PrintMessage()
        {
            Console.WriteLine("Interface1 implemented");
            
        }
        void Interface2.PrintMessage()
        {
            Console.WriteLine("Interface2 implemented");

        }
    }
}
