using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
