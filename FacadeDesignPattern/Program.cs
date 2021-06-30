using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            RestaurantFacade restaurantFacade = new RestaurantFacade();
            restaurantFacade.GetNonVegPizza();
            restaurantFacade.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            restaurantFacade.GetGarlicBread();
            restaurantFacade.GetCheeseGarlicBread();
            Console.ReadKey();
        }
    }
}
