using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Builders;
using Vehicles.Library.Decorators;
using Vehicles.Library.Enums;
using Vehicles.Library.Factories;
using Vehicles.Library.Models;
using Vehicles.Library.Strategies.PaintStrategy;

namespace Vehicles.Library.Facade
{
    public class CarFacade
    {
        public Vehicle Build<TStrategy>(EngineType engineType, Color color, int maxSpeed) where TStrategy : IPaintStrategy
        {
            var car = new CarBuilder()
                .SetEngineType(engineType)
                .SetColor<TStrategy>(color)
                .SetMaxSpeed(maxSpeed)
                .Build();

            return car;
        }

        public Vehicle Create()
        {
            var factory = new LandcraftFactory();
            var car = factory.Create<Car>();

            return car;
        }

        public void AddWeapon(Vehicle car, Weapon weapon)
        {
            var carDecorator = new VehicleDecorator(car);

            switch (weapon)
            {
                case Weapon.Axe:
                    carDecorator = new AxeDecorator(carDecorator);
                    break;
                case Weapon.Bow:
                    carDecorator = new BowDecorator(carDecorator);
                    break;
                case Weapon.Gun:
                    carDecorator = new GunDecorator(carDecorator);
                    break;
                case Weapon.Knife:
                    carDecorator = new KnifeDecorator(carDecorator);
                    break;
                case Weapon.Sword:
                    carDecorator = new SwordDecorator(carDecorator);
                    break;
            }

            Console.WriteLine($"Att: {carDecorator.GetAtt()}");
        }

        public void AddDefense(Vehicle car, Defense defense)
        {
            var carDecorator = new VehicleDecorator(car);

            switch (defense)
            {
                case Defense.Armor:
                    carDecorator = new ArmorDecorator(carDecorator);
                    break;
                case Defense.Gloves:
                    carDecorator = new GlovesDecorator(carDecorator);
                    break;
                case Defense.Helmet:
                    carDecorator = new HelmetDecorator(carDecorator);
                    break;
                case Defense.Shield:
                    carDecorator = new ShieldDecorator(carDecorator);
                    break;
            }

            Console.WriteLine($"Def: {carDecorator.GetDef()}");
        }
    }
}
