using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;

namespace Vehicles.Library.Builders
{
    public class CarBuilder : VehicleBuilder<Car>
    {
        public VehicleBuilder<Car> SetEngineType(EngineType engineType)
        {
            _vehicle.EngineType = engineType;
            return this;
        }
    }
}
