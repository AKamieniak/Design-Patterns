﻿﻿using Vehicles.Library.Abstractions;
using Vehicles.Library.Decorators;
using Vehicles.Library.Models;
using Vehicles.Library.Builders;
using Vehicles.Library.Enums;
using Vehicles.Library.Strategies.PaintStrategy;
using Vehicles.Library.Facade;
using Vehicles.Library.Strategies.MoveStrategy;

  namespace Vehicles.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorUsage();
            BuilderUsage();
            FlyStrategyUsage();
            FacadeUsage();
        }

        public static void DecoratorUsage()
        {
            VehicleDecorator carDecorator = new ShieldDecorator(new Car());
            System.Console.WriteLine($"Att: {carDecorator.GetAtt()}, Def: {carDecorator.GetDef()}");
            carDecorator = new SwordDecorator(carDecorator);
            System.Console.WriteLine($"Att: {carDecorator.GetAtt()}, Def: {carDecorator.GetDef()}");
            carDecorator = new ArmorDecorator(carDecorator);
            carDecorator = new BowDecorator(carDecorator);
            System.Console.WriteLine($"Att: {carDecorator.GetAtt()}, Def: {carDecorator.GetDef()}");
        }

        public static void BuilderUsage()
        {
            var car = new CarBuilder()
                .SetEngineType(EngineType.Diesel)
                .SetColor<StripesStrategy>(Color.Gray)
                .SetMaxSpeed(120)
                .Build();
            System.Console.WriteLine($"EngineType: {car.EngineType}," +
                                     $" Color: {car.Color}," +
                                     $" MaxSpeed: {car.MaxSpeed}");
        }

        public static void FlyStrategyUsage()
        {
            Vehicle car = new AircraftCarrier();
            System.Console.WriteLine($"Move: {car.MovingType.Move()}");
            car.Move<DriveStrategy>();
            System.Console.WriteLine($"Move: {car.MovingType.Move()}");

            System.Console.Read();
	}

        public static void FacadeUsage()
        {
            var carFacade = new CarFacade();
            var car = carFacade.Build<StripesStrategy>(EngineType.Diesel, Color.Black, 60);
            var car2 = carFacade.Create();
            carFacade.AddWeapon(car, Weapon.Axe);
            carFacade.AddDefense(car, Defense.Gloves);
        }
    }
}
