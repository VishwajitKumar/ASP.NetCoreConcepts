using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Rectangle : IRectangle
    {
        public double GetRectangleArea(double length,double breadth)
        {
            return length*breadth;
        }
        
    }
}
