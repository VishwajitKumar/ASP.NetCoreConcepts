using FacadeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Implementations
{
    class Pizza : IPizza
    {
        public void GetNonVegPizza()
        {

            GetNonVegToppings();
            Console.WriteLine("Getting Non VegPizza");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Added NonVeg Toppings");
        }
    }
}
