using FacadeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Implementations
{
    class Bread : IBread
    {
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheese Garlic bread.");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Added Cheese");
        }
    }
}
