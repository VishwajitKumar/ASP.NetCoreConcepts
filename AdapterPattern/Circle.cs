using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
   public class Circle:ICircle
    {
        public double GetCircleArea(double radius)
        {
            return 3.141 * radius * radius;
        }
    }
}
