using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;

namespace Vehicles.Library.Builders
{
    public class DroneBuilder : VehicleBuilder<Drone>
    {
        public VehicleBuilder<Drone> SetEngineType(EngineType engineType)
        {
            _vehicle.EngineType = engineType;
            return this;
        }
    }
}
