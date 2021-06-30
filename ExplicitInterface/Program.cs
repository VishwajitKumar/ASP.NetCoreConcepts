using System;


namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit interface implementation
            Class1 class1 = new Class1();
            ((Interface1)class1).PrintMessage();
            ((Interface2)class1).PrintMessage();
            Interface1 I1 = new Class1();
            Interface2 I2 = new Class1();
            I1.PrintMessage();
            I2.PrintMessage();
            Console.ReadKey();
        }
    }
}
