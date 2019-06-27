using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Models
{
    public class Boat : Vehicle, IWatercraftVehicle
    {
        public Boat()
        {
            MovingType = new SwimStrategy();
        }

        public override void Move<TStrategy>()
        {
            MovingType = new TStrategy();
            Console.WriteLine("Boat sound");
        }
    }
}
