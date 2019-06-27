using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;

namespace Vehicles.Library.Builders
{
    public class BoatBuilder : VehicleBuilder<Boat>
    {
        public VehicleBuilder<Boat> SetEngineType(EngineType engineType)
        {
            _vehicle.EngineType = engineType;
            return this;
        }
    }
}
