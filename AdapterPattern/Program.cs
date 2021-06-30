using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRectangle rectangle = new Rectangle();
            ICircle circle = new Circle();
            AreaAdapter areaAdapter = new AreaAdapter(circle);

            Console.WriteLine($"Area of rectangle is: {rectangle.GetRectangleArea(10,20)}");
            Console.WriteLine($"Area of circle is: {circle.GetCircleArea(10)}");
            Console.WriteLine($"Area of circle is: {areaAdapter.GetRectangleArea(10,20)}");

            Console.ReadKey();

        }
    }
}
