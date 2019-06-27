using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Models
{
    public class Bike : Vehicle, ILandcraftVehicle
    {
        public Bike()
        {
            MovingType = new DriveStrategy();
        }

        public override void Move<TStrategy>()
        {
            MovingType = new TStrategy();
            Console.WriteLine("Bike sound");
        }
    }
}
