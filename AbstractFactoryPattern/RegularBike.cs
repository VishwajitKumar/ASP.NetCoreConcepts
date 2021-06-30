using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class RegularBike:IBike
    {
        public string BikeType()
        {
            return "Regular Bike";
        }
    }
}
