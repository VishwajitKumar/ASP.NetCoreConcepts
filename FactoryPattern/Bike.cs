using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Bike : IFactory
    {
        public void Mileage(int km)
        {
            Console.WriteLine($"Bike mileage is: {km} km");
        }
    }
}
