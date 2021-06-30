using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class VehicleClient
    {
        IBike bike;
        IScooty scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBikeType(type);
            scooter = factory.GetScootyType(type);
        }

        public string GetBikeName()
        {
            return bike.BikeType();
        }

        public string GetScooterName()
        {
            return scooter.ScootyType();
        }
    }
}
