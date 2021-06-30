using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class SportsBike:IBike
    {
        public string BikeType()
        {
            return "SportsBike";
        }
    }
}
