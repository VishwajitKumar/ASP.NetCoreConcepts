using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClassDemo
{
    class Circle
    {
        //Making pi as static because pi value is constant. it will never change. 
        //So, after making it static only one memory will allocate to store the value. 
        //Hence program will take less memory and will be more efficient 
        static float pi;
        //readonly field can be reassigned in constructor
        readonly float radius=2;
        //Static constructor doesnt allow access modifier. Static constructor is used to initialise static member of the class
        //Static constructor called only once and before the instance constructor called.
        static Circle()
        {
            pi = 3.141f;
            Console.WriteLine("Static constructor");
        }
        public Circle(float radius)
        {
            Console.WriteLine("instance constructor");
            this.radius = radius;
        }

        public float CalculateArea()
        {
            return pi * radius * radius;
        }
       
    }
}
