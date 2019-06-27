using System;
using Vehicles.Library.Enums;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Abstractions
{
    public abstract class Vehicle : IDecorator
    {
        public Guid Id { get; set; }
        public int MaxSpeed { get; set; }
        public EngineType EngineType { get; set; }
        public Color Color { get; set; }
        public IMoveStrategy MovingType { get; set; }

        public abstract void Move<TStrategy>() where TStrategy : IMoveStrategy, new();

        public int GetAtt() => 0;
        public int GetDef() => 0;
    }
}
