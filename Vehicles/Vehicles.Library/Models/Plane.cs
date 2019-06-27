using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Models
{
    public class Plane : Vehicle, IAircraftVehicle
    {
        public Plane()
        {
            MovingType = new FlyStrategy();
        }

        public override void Move<TStrategy>()
        {
            MovingType = new TStrategy();
            Console.WriteLine("Plane sound");
        }
    }
}
