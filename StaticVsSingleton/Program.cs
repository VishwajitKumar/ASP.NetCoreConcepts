using StaticClassDemo;
using System;

namespace Static
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"Circle area: { circle.CalculateArea()}");
            Console.ReadLine();
        }
    }
}