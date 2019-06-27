using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Models
{
    public class AircraftCarrier : Vehicle, IAircraftVehicle
    {
        public AircraftCarrier()
        {
            MovingType = new FlyStrategy();
        }

        public override void Move<TStrategy>()
        {
            Console.WriteLine("AircraftCarrier sound");
            MovingType = new TStrategy();
        }
    }
}
