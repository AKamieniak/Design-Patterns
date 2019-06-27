using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;

namespace Vehicles.Library.Builders
{
    public class RocketBuilder : VehicleBuilder<Rocket>
    {
        public VehicleBuilder<Rocket> SetEngineType(EngineType engineType)
        {
            _vehicle.EngineType = engineType;
            return this;
        }
    }
}
