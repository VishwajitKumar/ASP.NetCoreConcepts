using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class HondaFactory : IVehicleFactory
    {
        public IBike GetBikeType(string bikeType)
        {
            return bikeType switch
            {
                "RgularBike" => new RegularBike(),
                "SportsBike" => new SportsBike(),
                _ => throw new ApplicationException($"Vehicle {bikeType} cannot be created"),
            };
        }

        public IScooty GetScootyType(string scootyType)
        {
            return scootyType switch
            {
                "RegularScooty" => new RegularScooty(),
                "SportsScooty" => new SportsScooty(),
                _ => throw new ApplicationException($"Vehicle {scootyType} cannot be created"),
            };
        }
    }
}
