using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class HeroFactory : IVehicleFactory
    {
        IBike IVehicleFactory.GetBikeType(string bikeType)
        {
            return bikeType switch
            {
                "RegularBike" => new RegularBike(),
                "SportsBike" => new SportsBike(),
                _ => throw new ApplicationException($"Vehicle {bikeType} cannot be created"),
            };
        }

        IScooty IVehicleFactory.GetScootyType(string scootyType)
        {
            return scootyType switch
            {
                "RegularScooty" => new RegularScooty(),
                "SportsScooty"=>new SportsScooty(),
                _=>throw new ApplicationException($"Vehicle {scootyType} cannot be created")
            };
        }
    }
}
