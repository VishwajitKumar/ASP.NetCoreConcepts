using System;

namespace FactoryPattern
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            ConcreteVehicleFactory concreteVehicleFactory = new ConcreteVehicleFactory();
            IFactory bike = concreteVehicleFactory.GetVehicle("Bike");
            bike.Mileage(50);
            IFactory scooty = concreteVehicleFactory.GetVehicle("scooty");
            scooty.Mileage(40);
            Console.ReadKey();
        }
    }
}
