using StaticClassDemo;
using System;

namespace Static
{
    class Program
    {
        string name = "Demo Program";
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.name = "Hi";
            Circle circle = new Circle(10);
            Console.WriteLine($"Circle area: { circle.CalculateArea()}");
            program.SetRootFolder("Hi");
            Console.ReadLine();
        }
        public void SetRootFolder(string path) { }
    }
}