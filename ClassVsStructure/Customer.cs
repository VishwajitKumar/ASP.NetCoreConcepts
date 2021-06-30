using System;
using System.Collections.Generic;
using System.Text;

namespace ClassVsStructure
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void PrintClassCustomerDetails()
        {
            Console.WriteLine($"Class Customer details: Id={Id} Name={Name}");
        }
    }

    struct CustomerStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CustomerStruct(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void PrintStructCustomerDetails()
        {
            Console.WriteLine($"Struct Customer details: Id={Id} Name={Name}");
        }
    }
}
