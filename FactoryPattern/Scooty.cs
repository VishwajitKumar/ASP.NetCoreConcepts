using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Scooty : IFactory
    {
        public void Mileage(int km)
        {
            Console.WriteLine($"Scooty mileage is: {km} km");
        }
    }
}
