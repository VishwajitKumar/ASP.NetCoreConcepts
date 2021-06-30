using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Interfaces
{
    interface IVehicleFactory
    {
        IBike GetBikeType(string bikeType);
       IScooty GetScootyType(string scootyType);
    }
}
