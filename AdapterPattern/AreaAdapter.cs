using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class AreaAdapter : IRectangle
    {
        private readonly ICircle _circle;
        public AreaAdapter(ICircle circle)
        {
            _circle = circle;
        }
        public double GetRectangleArea(double length, double breadth)
        {
            return _circle.GetCircleArea(50);
        }
    }
}
