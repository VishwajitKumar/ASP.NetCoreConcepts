using FacadeDesignPattern.Implementations;
using FacadeDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class RestaurantFacade
    {
        private IPizza _pizza;
        private IBread _bread;
        public RestaurantFacade()
        {
            _pizza = new Pizza();
            _bread = new Bread();
        }

        public void GetVegPizza()
        {
            _pizza.GetVegPizza();
        }
        public void GetNonVegPizza()
        {
            _pizza.GetNonVegPizza();
        }
        public void GetGarlicBread()
        {
            _bread.GetGarlicBread();
        }
        public void GetCheeseGarlicBread()
        {
            _bread.GetCheesyGarlicBread();
        }
    }
}
