using Vehicles.Library.Enums;
using Vehicles.Library.Strategies.PaintStrategy;

namespace Vehicles.Library.Abstractions
{
    public abstract class VehicleBuilder<T> where T : Vehicle, new()
    {
        protected T _vehicle = new T();

        public VehicleBuilder<T> SetColor<TStrategy>(Color color) where TStrategy : IPaintStrategy
        {
            _vehicle.Color = color;
            return this;
        }

        public VehicleBuilder<T> SetMaxSpeed(int maxSpeed)
        {
            _vehicle.MaxSpeed = maxSpeed;
            return this;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
