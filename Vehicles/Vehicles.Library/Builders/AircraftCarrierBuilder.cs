using Vehicles.Library.Abstractions;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;

namespace Vehicles.Library.Builders
{
    public class AircraftCarrierBuilder : VehicleBuilder<AircraftCarrier>
    {
        public VehicleBuilder<AircraftCarrier> SetEngineType(EngineType engineType)
        {
            _vehicle.EngineType = engineType;
            return this;
        }
    }
}
