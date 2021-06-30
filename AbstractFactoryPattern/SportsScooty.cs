using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class SportsScooty:IScooty
    {
        string IScooty.ScootyType()
        {
            return "Sports Scooty";
        }
    }
}
