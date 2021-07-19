using System;

namespace ConstructorConcept
{
    class Program
    {
        //Normally base class PARAMETERLESS constructor called first when child class object gets created.
        //But if we want parameterised constructor to be called then
        //we inherite child class constructor from inbuilt base method with matching parameter with base class constructor.
        //refer line public ChildClass():base("Derived class constructor controlling base class constructor execution")
        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();
            Console.ReadKey();
        }
    }

    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class constructor called first");
        }
        public ParentClass(string Parameterised)
        {
            Console.WriteLine($"{Parameterised}");
        }
    }
    class ChildClass:ParentClass
    {
        public ChildClass():base("Derived class constructor controlling base class constructor execution")
        {
            Console.WriteLine("Child class constructor");
        }

    }
}
