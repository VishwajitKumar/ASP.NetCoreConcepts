using System;

namespace ClassVsStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerClass = new Customer(1,"Ram");
            CustomerStruct customerStruct = new CustomerStruct();
            customerClass.PrintClassCustomerDetails();
            customerStruct.PrintStructCustomerDetails();
            Console.ReadKey();
        }
    }
}
