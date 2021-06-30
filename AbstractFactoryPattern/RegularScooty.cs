using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class RegularScooty:IScooty
    {
        string IScooty.ScootyType()
        {
            return "Regular Scooty";
        }
    }
}
