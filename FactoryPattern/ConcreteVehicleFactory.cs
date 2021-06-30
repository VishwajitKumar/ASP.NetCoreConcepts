using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            return vehicle switch
            {
                "scooty" => new Scooty(),
                "Bike" => new Bike(),
                _ => throw new ApplicationException($"Vehicle {vehicle} cannot be created"),
            };
        }
    }
}
